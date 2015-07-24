using Imgur.API.Model.Requests;

namespace Imgur.API.EndPoints.Gallery
{
    public class GetUserGalleryFavorites : RequestBase
    {
//Account Gallery Favorites
//Return the images the user has favorited in the gallery.
//Method	GET
//Route	https://api.imgur.com/3/account/{username}/gallery_favorites/{page}/{sort}
//Response Model	Gallery Image OR Gallery Album
//Parameters
//Key	Required	Description
//page	optional	integer - allows you to set the page number so you don't have to retrieve all the data at once.
//sort	optional	'oldest', or 'newest'. Defaults to 'newest'.

        public string UserName { get; set; }
        public string sort { get; set; }
        public string page { get; set; }

        public override string CallIdentifier
        {
            //get { return string.Format("gallery/{section}/{sort}/{window}/{page}?showViral=bool",); }
            get { return string.Format("account/{0}/gallery_favorites/{1}/{2}", UserName, sort, page); }
        }
    }
}