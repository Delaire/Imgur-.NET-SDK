using Imgur.API.Model.Requests;

namespace Imgur.API.EndPoints.Gallery
{
//    public class GetCommentsIds : RequestBase
//    {
////        Route	https://api.imgur.com/3/gallery/album/{id}/comments/ids
////Route	https://api.imgur.com/3/gallery/image/{id}/comments/ids
////Route	https://api.imgur.com/3/gallery/{id}/comments/ids

        
//        public string type { get; set; }
//        public string CommentId { get; set; }

//        public override string CallIdentifier
//        {
//            //get { return string.Format("gallery/{section}/{sort}/{window}/{page}?showViral=bool",); }
//            get { return string.Format("gallery/{0}{1}comments/ids", type, CommentId); }
//        }
//    }
    public class GetComments : RequestBase
    {
//       Route	https://api.imgur.com/3/gallery/album/{id}/comments/{sort}
//Route	https://api.imgur.com/3/gallery/image/{id}/comments/{sort}
//Route	https://api.imgur.com/3/gallery/{id}/comments/{sort}

        public string sort { get; set; }
        public string type { get; set; }
        public string CommentId { get; set; }

        public override string CallIdentifier
        {
            //get { return string.Format("gallery/{section}/{sort}/{window}/{page}?showViral=bool",); }
            get { return string.Format("https://imgur.com/gallery/{0}{1}comment/best/hit.json", type, CommentId); }
        }
    }


    //public class GetCommentFromGallery : RequestBase
    //{
    //    //https://api.imgur.com/3/gallery/{id}/comment/{id}
    //    public string CommentId { get; set; }
    //    public string GalleryId { get; set; }

    //    public override string CallIdentifier
    //    {
    //        //get { return string.Format("gallery/{section}/{sort}/{window}/{page}?showViral=bool",); }
    //        get { return string.Format("gallery/{0}/comment/{1}", GalleryId,CommentId); }
    //    }
    //}
    //public class GetComment : RequestBase
    //{
    //    //       Route	https://api.imgur.com/3/comment/{id}
    //    public string CommentId { get; set; }

    //    public override string CallIdentifier
    //    {
    //        //get { return string.Format("gallery/{section}/{sort}/{window}/{page}?showViral=bool",); }
    //        get { return string.Format("comment/{0}", CommentId); }
    //    }
    //}

}