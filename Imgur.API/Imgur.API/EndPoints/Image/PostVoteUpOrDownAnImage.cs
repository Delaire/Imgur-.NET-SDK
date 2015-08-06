using Imgur.API.Model.Requests;

namespace Imgur.API.EndPoints.Gallery
{
    public class PostVoteUpOrDownAnImage : PostRequestBase
    {
//       Album / Image Voting
//Vote for an image, 'up' or 'down' vote. Send the same value again to undo a vote.
//Method	POST
//Route	https://api.imgur.com/3/gallery/album/{id}/vote/{vote}
//Route	https://api.imgur.com/3/gallery/image/{id}/vote/{vote}
//Route	https://api.imgur.com/3/gallery/{id}/vote/{vote}
//Response Model	Basic

        public string imageId { get; set; }
        public string type { get; set; }
        public string voteType { get; set; }


        public override string CallIdentifier
        {
            //get { return string.Format("gallery/{section}/{sort}/{window}/{page}?showViral=bool",); }
            get { return string.Format("gallery/{0}{1}/vote/{2}", imageId, type, voteType); }
        }

        public override string CallPostMessage
        {
            get { return string.Format(""); }
        }
    }
}