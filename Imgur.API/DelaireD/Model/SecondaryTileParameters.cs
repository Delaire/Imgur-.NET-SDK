using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelaireD.Model
{
    public class SecondaryTileParameters : TileParameters
    {
        public SecondaryTileParameters(string id, string name, int count, string title, Type viewModelType, string backTitle, string backContent,
             Uri backBackgroundImageUri, Uri backgroundImageUri, IList<Uri> collectionListUri)
        {
            Id = id;
            Name = name;
            Count = count;
            Title = title;
            ViewModelType = viewModelType;
            BackTitle = backTitle;
            BackContent = backContent;
            BackBackgroundImageUri = backBackgroundImageUri;
            BackgroundImageUri = backgroundImageUri;
            CollectionListUri = collectionListUri;
        }

        public override TileType TileType
        {
            get { return TileType.SecondaryTile; }
        }
        public Uri BackgroundImageUri { get; set; }
        public Type ViewModelType { get; set; }
        public IList<Uri> CollectionListUri { get; set; }
        public string Title { get; set; }
        public string BackTitle { get; set; }
        public string BackContent { get; set; }
        public Uri BackBackgroundImageUri { get; set; }
    }

    public abstract class TileParameters
    {
        abstract public TileType TileType
        {
            get;
        }
        public int Count
        {
            get;
            set;
        }
        public string Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }

    }


    public class PrimaryTileParameters : TileParameters
    {
        public override TileType TileType
        {
            get { return TileType.Primary; }
        }

        public PrimaryTileParameters(string id, string name, int count, string title, string backTitle,
            string backContent, Uri backBackgroundImageUri, Uri smallBackgroundImage, Uri wideBackBackgroundImage,
            string wideBackContent, Uri wideBackgroundImage, Uri backgroundImageUri)
        {
            Id = id;
            Name = name;
            Count = count;
            Title = title;
            BackTitle = backTitle;
            BackContent = backContent;

            BackBackgroundImageUri = backBackgroundImageUri;
            SmallBackgroundImage = smallBackgroundImage;
            WideBackBackgroundImage = wideBackBackgroundImage;
            WideBackContent = wideBackContent;
            WideBackgroundImage = wideBackgroundImage;
            BackgroundImageUri = backgroundImageUri;
        }

        public string Title { get; set; }
        public string BackTitle { get; set; }
        public string BackContent { get; set; }
        public Uri BackBackgroundImageUri { get; set; }
        public Uri SmallBackgroundImage { get; set; }
        public Uri WideBackBackgroundImage { get; set; }
        public string WideBackContent { get; set; }
        public Uri WideBackgroundImage { get; set; }
        public Uri BackgroundImageUri { get; set; }

    }

}
