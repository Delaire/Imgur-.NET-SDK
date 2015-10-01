using Imgur.API.Model.Requests;

namespace Imgur.API.EndPoints.Gallery
{
    public class GetRandomGalleryImages : RequestBase
    {
        //        Returns a random set of gallery images.
        //Method	GET
        //Route	https://api.imgur.com/3/gallery/random/random/{page}
        //Response Model	Gallery Image OR Gallery Album
        //Parameters
        //Key	Required	Value
        //page	optional	A page of random gallery images, from 0-50. Pages are regenerated every hour.

        public int page { get; set; }

        public override string CallIdentifier
        {
            //get { return string.Format("gallery/{section}/{sort}/{window}/{page}?q=query",); }
            get { return string.Format("gallery/random/random/{0}", page); }
        }
    }
}