using Imgur.API.Model.Requests;

namespace Imgur.API.EndPoints.Gallery
{
    public class PostGalleryCommentsReply : PostRequestBase
    {
//Album / Image Comment Reply Creation
//Reply to a comment that has been created for an image.
//Method	POST
//Route	https://api.imgur.com/3/gallery/album/{id}/comment/{id}
//Route	https://api.imgur.com/3/gallery/image/{id}/comment/{id}
//Route	https://api.imgur.com/3/gallery/{id}/comment/{id}
//Response Model	Basic
//Parameters
//Key	Required	Value
//comment	required	The text you want to use as the reply.
      
        public string type { get; set; }
        public string commentId { get; set; }
        public string galleryId { get; set; }
        public string comment { get; set; }

        public override string CallIdentifier
        {
            //get { return string.Format("gallery/{section}/{sort}/{window}/{page}?showViral=bool",); }
            get { return string.Format("gallery/{0}{1}/comment/{2}", galleryId, type, commentId); }
        }

        public override string CallPostMessage
        {
            get { return string.Format("comment={0}", comment); }
        }
    }
}