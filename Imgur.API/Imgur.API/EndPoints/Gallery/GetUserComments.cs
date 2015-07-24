using Imgur.API.Model.Requests;

namespace Imgur.API.EndPoints.Gallery
{
    public class GetUserComments : RequestBase
    {
// Return the comments the user has created.
//Method	GET
//Route	https://api.imgur.com/3/account/{username}/comments/{sort}/{page}
//Response Model	Comment
//Parameters
//Key	Required	Value
//sort	optional	'best', 'worst', 'oldest', or 'newest'. Defaults to 'newest'.
//page	optional	Page number (50 items per page). Defaults to 0.

        public string UserName { get; set; }
        public string sort { get; set; }
        public string page { get; set; }

        public override string CallIdentifier
        {
            //get { return string.Format("gallery/{section}/{sort}/{window}/{page}?showViral=bool",); }
            get { return string.Format("account/{0}/comments/{1}/{2}", UserName, sort, page); }
        }
    }
}