using Imgur.API.Model.Requests;

namespace Imgur.API.EndPoints.Gallery
{
    public class RefreshTokenQuery : RequestBase
    {

        public string token { get; set; }
        public string refreshToken { get; set; }
        public string accountName { get; set; }
        public string accountId { get; set; }

        public override string CallIdentifier
        {
            //
            get { return string.Format("https://api.imgur.com/oauth2/token"); }
        }
    }
}