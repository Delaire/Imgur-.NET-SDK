using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Imgur.API.EndPoints.Gallery;
using Imgur.API.Factory;
using Imgur.API.Model;
using Imgur.API.Model.Requests;
using Imgur.API.Service;
using Imgur.API.Service.DataService;
using Imgur.API.Services.AuthenticationService;
using Imgur.API.Services.DataService;
using Microsoft.Practices.ServiceLocation;
using Microsoft.VisualBasic.CompilerServices;

namespace Imgur.API
{
    public class ApiRoot : IApiRoot
    {
        private ApiRoot()
        {

        }

        private static ApiRoot _instance;

        /// <summary>
        /// The singleton ApiRoot instance
        /// </summary>
        public static ApiRoot Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ApiRoot();
                }

                return _instance;
            }
        }

        /// <summary>
        /// Returns TRUE if the SDK has been initialized. Initialize the SDK by calling Init().
        /// </summary>
        public bool IsInitialized { get; private set; }

        public bool IsLoggedIn
        {
            get
            {
                if (AccessToken != null 
                    && AccessToken.ExpectedExpirationDateUtc > DateTime.Now)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public string _clientId;
        public string ClientId
        {
            get { return _clientId; }
        }

       


        public void Init(string clientId, string apiSecret)
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            //Register Services
            SimpleIoc.Default.Register<IDataService, DataService>();
            SimpleIoc.Default.Register<IHttpClientFactory, HttpClientFactory>();
            //SimpleIoc.Default.Register<IAuthenticationService, AuthenticationService>();
            
            //Todo: why am i doing this?
            _clientId = clientId;

            //FOr Oauth2 stuff
            var authService = new AuthenticationService(clientId, apiSecret);
            authService.AccessTokenRefreshed += authService_AccessTokenRefreshed;

            SimpleIoc.Default.Register<IAuthenticationService>(()=> authService);

            IsInitialized = true;
        }

        public async Task<T> GetEndPointEntityAsync<T>(RequestBase req)
        {
            return
                await SimpleIoc.Default.GetInstance<IDataService>()
                    .GetEndPointEntityAsync<T>(req);
        }

        public async Task<T> PostEndPointEntityAsync<T>(RequestBase req)
        {
            return
                await SimpleIoc.Default.GetInstance<IDataService>()
                    .PostEndPointEntityAsync<T>(req);
        }



        public async Task<T> MakeQueryWithoutApiAuth<T>(RequestBase req)
        {
            return
                (T) await SimpleIoc.Default.GetInstance<IDataService>()
                    .MakeQueryWithoutApiAuth<T>(req);
        }

        #region Logins

        /// <summary>
        /// Gets or sets the AccessToken currently used for API communication.
        /// </summary>
        public AccessToken AccessToken
        {
            get
            {
                return SimpleIoc.Default.GetInstance<IAuthenticationService>().AccessToken;
            }
            set
            {
                SimpleIoc.Default.GetInstance<IAuthenticationService>().AccessToken = value;
            }
        }



        /// <summary>
        /// Delegate for handling the AccessTokenRefreshed event of the ApiRoot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void AccessTokenHandler(object sender, AccessTokenEventArgs e);

        /// <summary>
        /// Fired whenever the stored access token is refreshed from the server
        /// </summary>
        public event AccessTokenHandler AccessTokenRefreshed;

        private void authService_AccessTokenRefreshed(object sender, AccessTokenEventArgs e)
        {
            if (AccessTokenRefreshed != null)
            {
                AccessTokenRefreshed(this, e);
            }
        }


        /// <summary>
        /// Requests a refresh of the currently stored access token
        /// </summary>
        /// <returns>Access Token for the user</returns>
        public async Task<AccessToken> RefreshAccessTokenAsync()
        {
            return  await SimpleIoc.Default.GetInstance<IAuthenticationService>().RefreshTokenAsync();
        }

        public AccessToken LoginWithAccessTokenAsync(string fragment)
        {
            var token = new AccessToken();

            try
            {
                var elements = fragment.Replace('#', ' ').Split('&');

                token.AccountId = elements.First(a => a.Contains("account_id")).Split('=')[1];
                token.Token = elements.First(a => a.Contains("access_token")).Split('=')[1];
                token.RefreshToken = elements.First(a => a.Contains("refresh_token")).Split('=')[1];
                token.UserName = elements.First(a => a.Contains("account_username")).Split('=')[1];
                token.ExpiresIn = elements.First(a => a.Contains("expires_in")).Split('=')[1];
                token.ExpectedExpirationDateUtc = DateTime.Now.AddMinutes((int.Parse(token.ExpiresIn)));

                
                SimpleIoc.Default.GetInstance<IAuthenticationService>().AccessToken = token;

            }
            catch (Exception ex)
            {
                var data = ex;
            }

            return token;
        }


        /// <summary>
        /// Logs the user out of the API and forgets the stored access token.
        /// </summary>
        /// <returns></returns>
        public async Task LogoutAsync()
        {
            await SimpleIoc.Default.GetInstance<IAuthenticationService>().LogoutAsync();
        }

        #endregion
        //public async Task<T> GetEndPointEntityAsync<T>(string Id, List<string> requestedFields)

        //{
        //    return await Tools.MakeDataCall(async () =>
        //    {
        //        return await SimpleIoc.Default.GetInstance<IDataService>()
        //            .GetEndPointEntityAsync<T>(
        //            new GetSingleEntityRequest<T>(
        //                HttpMethod.Get, Id)
        //            {
        //                RequestedFields = requestedFields
        //            });
        //    });
        //}


    }
}
