using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Imgur.API.Model
{
    /// <summary>
    /// An access token for access to the Imgur API
    /// </summary>
    public class AccessToken
    {

        /// <summary>
        /// The token string
        /// </summary>
        [JsonProperty(PropertyName = "access_token")]
        public string Token { get; set; }

        /// <summary>
        /// Refresh token to be used to refresh the access token when it expires
        /// </summary>
        [JsonProperty(PropertyName = "refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// The length of time for which the token is valid, starting from the time it was requested
        /// </summary>
        [JsonProperty(PropertyName = "expires_in")]
        public TimeSpan ExpiresIn { get; set; }

        /// <summary>
        /// The expected expiration time of the access token.
        /// </summary>
        public DateTime ExpectedExpirationDateUtc { get; set; }

        /// <summary>
        /// Obtains a string representation of the access token
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Access token: valid until {0}, token={1}, refresh_token={2}", ExpectedExpirationDateUtc.ToString(), Token.EmptyIfNull(), RefreshToken.EmptyIfNull());
        }

        /// <summary>
        /// TRUE if this token was obtained by providing user credentials, false if it was obtained without credentials
        /// </summary>
        public bool IsUserToken
        {
            get
            {
                return !String.IsNullOrEmpty(RefreshToken);
            }
        }

       

       
    }
}
