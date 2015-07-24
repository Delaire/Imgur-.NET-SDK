using Imgur.API.Model.Requests;

namespace Imgur.API.EndPoints.Gallery
{
    public class GetUserSubmissions : RequestBase
    {
//Account Submissions
//Return the images a user has submitted to the gallery
//Method	GET
//Route	https://api.imgur.com/3/account/{username}/submissions/{page}
//Response Model	Gallery Image OR Gallery Album

        public string UserName { get; set; }
        public string page { get; set; }

        public override string CallIdentifier
        {
            //get { return string.Format("gallery/{section}/{sort}/{window}/{page}?showViral=bool",); }
            get { return string.Format("account/{0}/submissions/{1}", UserName, page); }
        }
    }
}