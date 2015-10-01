using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelaireD.Interfaces;

namespace DelaireD.Services
{
    public class FileStore : IFileStore
    {
        public void WriteFile(string path, string contents)
        {
            WriteFileCommon(path, (stream) =>
            {
                using (var sw = new StreamWriter(stream))
                {
                    sw.Write(contents);
                    sw.Flush();
                }
            });
        }

        public void WriteFile(string path, IEnumerable<byte> contents)
        {
            WriteFileCommon(path, (stream) =>
            {
                using (var binaryWriter = new BinaryWriter(stream))
                {
                    binaryWriter.Write(contents.ToArray());
                    binaryWriter.Flush();
                }
            });
        }

        public void WriteFile(string path, Action<System.IO.Stream> writeMethod)
        {
            WriteFileCommon(path, writeMethod);
        }

        private async void WriteFileCommon(string path, Action<Stream> streamAction)
        {
            // from https://github.com/MvvmCross/MvvmCross/issues/500 we delete any existing file
            // before writing the new one
            await SafeDeleteFile(path);

            try
            {
                var storageFile = await CreateStorageFileFromRelativePath(path);
                var streamWithContentType = await storageFile.OpenAsync(FileAccessMode.ReadWrite);
                using (var stream = streamWithContentType.AsStreamForWrite())
                {
                    streamAction(stream);
                }
            }
            catch (Exception ex)
            {
                SimpleIoc.Default.GetInstance<IErrorService>().ReportErrorInternalOnly(ex);
                throw;
            }
        }

        private async static Task<StorageFile> CreateStorageFileFromRelativePath(string path)
        {
            var fullPath = ToFullPath(path);
            var directory = Path.GetDirectoryName(fullPath);
            var fileName = Path.GetFileName(fullPath);
            var storageFolder = await StorageFolder.GetFolderFromPathAsync(directory);
            var storageFile = await storageFolder.CreateFileAsync(fileName);
            return storageFile;
        }




        public bool DeleteFile(string path)
        {
            return SafeDeleteFile(path).Result;
        }

        public async Task ForceDeleteFile(string path)
        {
            var fullPath = ToFullPath(path);
            var storageFile = await StorageFile.GetFileFromPathAsync(fullPath);
            await storageFile.DeleteAsync();
        }

        private async static Task<bool> SafeDeleteFile(string path)
        {
            try
            {
                var toFile = await StorageFileFromRelativePath(path);
                await toFile.DeleteAsync();
                return true;
            }
            catch (FileNotFoundException)
            {
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool TryReadBinaryFile(string path, Func<Stream, bool> readMethod)
        {
            var toReturn = TryReadFileCommon(path, readMethod).Result;
            return toReturn;
        }

        public Task<bool> TryReadBinaryFile(string path, out byte[] contents)
        {
            Byte[] result = null;
            var toReturn = TryReadFileCommon(path, (stream) =>
            {
                using (var binaryReader = new BinaryReader(stream))
                {
                    var memoryBuffer = new byte[stream.Length];
                    if (binaryReader.Read(memoryBuffer, 0, memoryBuffer.Length) != memoryBuffer.Length)
                        return false;

                    result = memoryBuffer;
                    return true;
                }
            });
            contents = result;
            return toReturn;
        }

        private async Task<bool> TryReadFileCommon(string path, Func<Stream, bool> streamAction)
        {
            try
            {
                var storageFile = await StorageFileFromRelativePath(path);
                if (storageFile != null)
                {
                    var streamWithContentType = await storageFile.OpenReadAsync();
                    using (var stream = streamWithContentType.AsStreamForRead())
                    {
                        return streamAction(stream);
                    }
                }
            }
            catch (Exception ex)
            {
                SimpleIoc.Default.GetInstance<IErrorService>().ReportErrorInternalOnly(ex);
                return false;
            }
            return false;
        }

        private async static Task<StorageFile> StorageFileFromRelativePath(string path)
        {
            if (await FileExistsAsync(path))
            {
                var fullPath = ToFullPath(path);
                var storageFile = await StorageFile.GetFileFromPathAsync(fullPath);
                return storageFile;
            }
            else
            {
                return null;
            }

        }

        public static async Task<bool> FileExistsAsync(string fileName)
        {
            try
            {
                var localFolderPath = Windows.Storage.ApplicationData.Current.LocalFolder;
                await localFolderPath.GetFileAsync(fileName);
                return true;
            }
            catch (FileNotFoundException)
            {
                return false;
            }
        }

        private static string ToFullPath(string path)
        {
            var localFolderPath = Windows.Storage.ApplicationData.Current.LocalFolder.Path;
            return System.IO.Path.Combine(localFolderPath, path);
        }

        #region folder
        public async void EnsureFolderExists(string folderPath)
        {
            if (FolderExists(folderPath))
                return;

            var rootFolder = ToFullPath(string.Empty);
            var storageFolder = await StorageFolder.GetFolderFromPathAsync(rootFolder);
            CreateFolderAsync(storageFolder, folderPath).GetAwaiter().GetResult();
        }

        public bool FolderExists(string folderPath)
        {
            try
            {
                folderPath = ToFullPath(folderPath);
                folderPath = folderPath.TrimEnd('\\');

                var thisFolder = StorageFolder.GetFolderFromPathAsync(folderPath);
                return true;
            }
            catch (System.UnauthorizedAccessException)
            {
                return false;
            }
            catch (FileNotFoundException)
            {
                return false;
            }
            catch (Exception ex)
            {
                SimpleIoc.Default.GetInstance<IErrorService>().ReportErrorInternalOnly(ex);
                throw;
            }
        }

        private static async Task<StorageFolder> CreateFolderAsync(StorageFolder rootFolder, string folderPath)
        {
            if (string.IsNullOrEmpty(folderPath))
                return rootFolder;
            var currentFolder = await CreateFolderAsync(rootFolder, Path.GetDirectoryName(folderPath)).ConfigureAwait(false);
            return await currentFolder.CreateFolderAsync(Path.GetFileName(folderPath), CreationCollisionOption.OpenIfExists).AsTask().ConfigureAwait(false);
        }

        #endregion
    }
}
