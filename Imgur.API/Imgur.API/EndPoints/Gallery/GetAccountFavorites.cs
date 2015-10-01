using Imgur.API.Model.Requests;

namespace Imgur.API.EndPoints.Gallery
{
    public class GetAccountFavorites : RequestBase
    {
//Account Favorites
//Returns the users favorited images, only accessible if you're logged in as the user.
//Method	GET
//Route	https://api.imgur.com/3/account/{username}/favorites
//Response Model	Gallery Image OR Gallery Album, Note: vote data ('ups', 'downs', and 'score') may be null if the favorited item hasn't been submitted to gallery

        public string UserName { get; set; }

        public bool IsLoginRequired = true;

        public override string CallIdentifier
        {
            //get { return string.Format("gallery/{section}/{sort}/{window}/{page}?showViral=bool",); }
            get { return string.Format("account/{0}/favorites", UserName); }
        }
    }
}