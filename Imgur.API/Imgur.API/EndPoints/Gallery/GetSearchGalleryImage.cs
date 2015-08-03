using Imgur.API.Model.Requests;

namespace Imgur.API.EndPoints.Gallery
{
    public class GetSearchGalleryImage : RequestBase
    {
//Key	Required	Value
//sort	optional	time | viral | top - defaults to time
//window	optional	Change the date range of the request if the sort is 'top', day | week | month | year | all, defaults to all.
//page	optional	integer - the data paging number
//Simple Search Query Parameters
//Key	Value
//q	Query string (note: if advanced search parameters are set, this query string is ignored). This parameter also supports boolean operators (AND, OR, NOT) and indices (tag: user: title: ext: subreddit: album: meme:). An example compound query would be 'title: cats AND dogs ext: gif'
////        Method	GET
//Route	https://api.imgur.com/3/gallery/search/{sort}/{page}
//Route	https://api.imgur.com/3/gallery/search/{sort}/{window}/{page}

     
        public string sort { get; set; }
        public string window { get; set; }
        public int page { get; set; }
        public string query { get; set; }

        public override string CallIdentifier
        {
            //get { return string.Format("gallery/{section}/{sort}/{window}/{page}?q=query",); }
            get { return string.Format("gallery/search/{0}/{1}/{2}?q={3}", sort, window, page, query); }
        }
    }
}