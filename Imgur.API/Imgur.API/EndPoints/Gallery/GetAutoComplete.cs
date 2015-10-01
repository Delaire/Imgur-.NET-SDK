using Imgur.API.Model.Requests;

namespace Imgur.API.EndPoints.Gallery
{
    public class GetAutoComplete : RequestBase
    {
        public string query { get; set; }

        public override string CallIdentifier
        {
           // get { return "http://imgur.com/search/suggest?q="; }
             get { return string.Format("http://imgur.com/search/suggest?q={0}", query); }
        }
    }
}