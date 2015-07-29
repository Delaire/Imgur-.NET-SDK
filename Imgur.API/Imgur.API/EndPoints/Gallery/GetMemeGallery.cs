using System.Net.Http;

namespace Imgur.API.EndPoints.Gallery
{
    public class GetMemeGallery : GetGalleryImage
    {
        public override string CallIdentifier
        {
            //https://api.imgur.com/3/g/memes/{sort}/{window}/{page}
            //get { return string.Format("gallery/3/g/memes/{sort}/{window}/{page}?showViral=bool",); }
            get { return string.Format("gallery/3/g/memes/{0}/{1}/{2}", sort, window, page); }
        }
    }
}
