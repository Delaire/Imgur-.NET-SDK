using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Imgur.API.Exceptions;

using Imgur.API.Model;
using Imgur.API.Services.AuthenticationService;
using Newtonsoft.Json;

namespace Imgur.API.Service
{
    //https://api.imgur.com/oauth2

    public class AuthenticationService : HttpServiceBase, IAuthenticationService
    {
        private readonly string _apiKey;
        private readonly string _apiSecret;
        private AccessToken _accessToken;
        
        private object _accessTokenLock = new object();

        /// <summary>
        /// Stored access token for the SDK
        /// </summary>
        public AccessToken AccessToken
        {
            get { return _accessToken; }
            set
            {
                lock (_accessTokenLock)
                {
                    _accessToken = value;
                }
            }
        }

        public AuthenticationService(string apiKey, string apiSecret)
        {
            _apiKey = apiKey;
            _apiSecret = apiSecret;
        }

        ///// <summary>
        ///// Authenticates the application without user credentials for read-only access
        ///// </summary>
        ///// <returns>An application-level access token for read-only API access</returns>
        //public async Task<AccessToken> AuthenticateAsync()
        //{
        //    var postData = string.Format(_apiKey,_apiSecret);

        //    return await ObtainAccessToken(postData);
        //}
        private const string RefreshTokenFormat =
           "grant_type=refresh_token&client_id={0}&client_secret={1}&refresh_token={2}";

        public async Task<AccessToken> RefreshTokenAsync()
        {
            if (AccessToken == null || String.IsNullOrEmpty(AccessToken.RefreshToken))
            {
                //No token to refresh, just authenticate
                //return await AuthenticateAsync();
                return null;
            }

            try
            {
                var postData = string.Format(RefreshTokenFormat,
                    _apiKey,
                    _apiSecret,
                    AccessToken.RefreshToken);


                return await ObtainAccessToken(postData);
            }
            catch (ApiException ex)
            {
                //Server can return invalid_grant if it doesn't like the refresh token. If so, do not rethrow  the exception.
                if (ex.Type != ApiExceptionType.InvalidCredentials)
                {
                    throw;
                }
            }

            // return await AuthenticateAsync();
            return null;
        }

        public async Task LogoutAsync()
        {
            if (TokenStatus == AccessTokenStatus.NoToken)
            {
                return;
            }

            var logoutUrl = String.Format("{0}?access_token={1}", Constants.AUTHENTICATION_LOGOUT_URL, AccessToken.Token);

            var message = new HttpRequestMessage(HttpMethod.Get, logoutUrl);

            var response = await HttpClient.SendAsync(message);

            if (response == null)
            {
                throw new ApiException("The server did not return a response.", ApiExceptionType.NoServerResponse);
            }

            if (response.IsSuccessStatusCode)
            {
                AccessToken = null;
            }
            else
            {
                var errorMsg = String.Format("The server returned status code {0} with error {1}",
                    response.StatusCode, response.ReasonPhrase);

                throw new ApiException(errorMsg, ApiExceptionType.ServerError);
            }
        }

        public AccessTokenStatus TokenStatus
        {
            get
            {
                lock (_accessTokenLock)
                {
                    if (_accessToken == null)
                    {
                        return AccessTokenStatus.NoToken;
                    }

                    return _accessToken.ExpectedExpirationDateUtc > DateTime.UtcNow
                        ? AccessTokenStatus.ValidToken
                        : AccessTokenStatus.TokenExpired;
                }
            }
        }

        private async Task<AccessToken> ObtainAccessToken(string postData)
        {
            var message = new HttpRequestMessage(HttpMethod.Post, Constants.AUTHENTICATION_URL)
            {
                Content = new StringContent(postData, Encoding.UTF8, "application/x-www-form-urlencoded"),
            };

            var response = await HttpClient.SendAsync(message);

            if (response == null)
            {
                throw new ApiException("The server did not return a response.", ApiExceptionType.NoServerResponse);
            }

            if (response.IsSuccessStatusCode)
            {
                if (response.Content == null)
                {
                    throw new ApiException("The server returned an empty response.", ApiExceptionType.NoServerResponse);
                }

                var responseJson = await response.Content.ReadAsStringAsync();

                if (String.IsNullOrEmpty(responseJson))
                {
                    throw new ApiException("The server returned an empty response.", ApiExceptionType.NoServerResponse);
                }

                try
                {
                    AccessToken = JsonConvert.DeserializeObject<AccessToken>(responseJson);
                    
                    AccessToken.ExpectedExpirationDateUtc = DateTime.Now.AddMinutes((int.Parse(AccessToken.ExpiresIn)));

                    if (AccessTokenRefreshed != null)
                    {
                        AccessTokenRefreshed(this, new AccessTokenEventArgs(AccessToken));
                    }

                    return AccessToken;
                }
                
                catch (Exception ex)
                {
                    throw new ApiException("The server did not return a response in the expected format.", ex, ApiExceptionType.InvalidServerResponse);
                }
            }
            else
            {
                var errorMsg = String.Format("The server returned status code {0} with error {1}",
                    response.StatusCode, response.ReasonPhrase);

                throw new ApiException(errorMsg, ApiExceptionType.ServerError);
            }
        }

        public delegate void AccessTokenHandler(object sender, AccessTokenEventArgs e);

        public event AccessTokenHandler AccessTokenRefreshed;
    }
}
