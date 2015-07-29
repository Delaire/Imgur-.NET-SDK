using Imgur.API.Model.Requests;

namespace Imgur.API.EndPoints.Gallery
{
    public class GetGalleryImage : RequestBase
    {
        //	https://api.imgur.com/3/gallery/{section}/{sort}/{window}/{page}?showViral=bool

        public string section { get; set; }
        public string sort { get; set; }
        public string window { get; set; }
        public int page { get; set; }
        public bool showViral { get; set; }

        public override string CallIdentifier
        {
            //get { return string.Format("gallery/{section}/{sort}/{window}/{page}?showViral=bool",); }
            get { return string.Format("gallery/{0}/{1}/{2}/{3}?showViral={4}", section,sort,window,page,showViral); }
        }
    }
}