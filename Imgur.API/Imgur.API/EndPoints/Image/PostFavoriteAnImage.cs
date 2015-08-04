using Imgur.API.Model.Requests;

namespace Imgur.API.EndPoints.Gallery
{
    public class PostFavoriteAnImage : PostRequestBase
    {
//Favorite an Image
//Favorite an image with the given ID. The user is required to be logged in to favorite the image.
//Method	POST
//Route	https://api.imgur.com/3/image/{id}/favorite
//Response Model	Basic

        public string imageId { get; set; }
      

        public override string CallIdentifier
        {
            //get { return string.Format("gallery/{section}/{sort}/{window}/{page}?showViral=bool",); }
            get { return string.Format("image/{0}/favorite", imageId); }
        }

        public override string CallPostMessage
        {
            get { return string.Format(""); }
        }
    }
}