using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imgur.API
{
    internal static class Constants
    {
        public const string AUTHENTICATION_URL = "https://api.imgur.com/oauth2/token";
        public const string AUTHENTICATION_SECRET = "https://api.imgur.com/oauth2/secret";
        public const string AUTHENTICATION_addclient = "https://api.imgur.com/oauth2/addclient";
        public const string AUTHENTICATION_authorize = "https://api.imgur.com/oauth2/authorize";

        public const string URL_BASE = "https://api.imgur.com/3/";

        public const string URL_ADVANCEDAPI = URL_BASE + "json";
        public const string ADVANCEDAPI_OAUTHTOKEN = "oauth_token={0}";


    }
}
