using Imgur.API.Model.Requests;

namespace Imgur.API.EndPoints.Gallery
{
    public class GetAccountAlbums : RequestBase
    {
//Albums
//Get all the albums associated with the account. Must be logged in as the user to see secret and hidden albums.
//Method	GET
//Route	https://api.imgur.com/3/account/{username}/albums/{page}
//Response Model	Album
//Parameters
//Key	Required	Description
//page	optional	integer - allows you to set the page number so you don't have to retrieve all the data at once.
  
        public string UserName { get; set; }
        public string page { get; set; }

       

        public override string CallIdentifier
        {
            //get { return string.Format("gallery/{section}/{sort}/{window}/{page}?showViral=bool",); }
            get { return string.Format("account/{0}/albums/{1}", UserName, page); }
        }
    }
}