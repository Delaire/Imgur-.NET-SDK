using Imgur.API.Model.Requests;

namespace Imgur.API.EndPoints.Gallery
{
    public class RefreshTokenQuery : RequestBase
    {
        //useless
        //public string grant_type { get; set; }
        //public string refresh_token { get; set; }
        //public string client_id { get; set; }
        //public string client_secret { get; set; }

        public override string CallIdentifier
        {
            //
            get { return string.Format("https://api.imgur.com/oauth2/token"); }
        }
    }
}