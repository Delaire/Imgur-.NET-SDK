using Imgur.API.Model.Requests;

namespace Imgur.API.EndPoints.Gallery
{
    public class PostGalleryComments : PostRequestBase
    {
//Album / Image Comment Creation
//Create a comment for an image.
//Method	POST
//Route	https://api.imgur.com/3/gallery/album/{id}/comment
//Route	https://api.imgur.com/3/gallery/image/{id}/comment
//Route	https://api.imgur.com/3/gallery/{id}/comment
//Response Model	Basic
//Parameters
//Key	Required	Value
//comment	required	The text of the comment.

      
        public string type { get; set; }
        public string commentId { get; set; }
        public string comment { get; set; }

        public override string CallIdentifier
        {
            //get { return string.Format("gallery/{section}/{sort}/{window}/{page}?showViral=bool",); }
            get { return string.Format("gallery/{0}{1}/comment", commentId, type); }
        }

        public override string CallPostMessage
        {
            get { return string.Format("comment={0}", comment); }
        }
    }
}