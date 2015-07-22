using Imgur.API.Model.Requests;

namespace Imgur.API.EndPoints.Gallery
{
    public class GeImagesOfGallery : RequestBase
    {
        public string query { get; set; }

        public override string CallIdentifier
        {
            //get { return string.Format("gallery/{section}/{sort}/{window}/{page}?showViral=bool",); }
            get { return string.Format("gallery/album/{0}", query); }
        }
    }
}