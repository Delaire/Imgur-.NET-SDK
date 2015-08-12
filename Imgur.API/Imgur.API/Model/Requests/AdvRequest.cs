using System.Net.Http;

namespace Imgur.API.Model.Requests
{
    public class AdvRequest : RequestBase
    {
        

        public AdvRequest(HttpMethod method)  
        {
            Method = method;
            //UrlToCall = urlToCall;
        }

        public override string CallIdentifier
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}