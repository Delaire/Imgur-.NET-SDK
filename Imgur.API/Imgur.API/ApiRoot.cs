using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imgur.API.Factory;
using Imgur.API.Ioc;
using Imgur.API.Model.Requests;
using Imgur.API.Service;
using Imgur.API.Service.DataService;
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

        public string _clientId;
        public string ClientId
        {
            get { return _clientId; }
        }

        public object AccessToken
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public void Init(string clientId, string apiSecret)
        {
            //SimpleIoc.Initialize();

            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            //Register Services
            SimpleIoc.Default.Register<IDataService, DataService>();
            SimpleIoc.Default.Register<IHttpClientFactory, HttpClientFactory>();
            SimpleIoc.Default.Register<IAuthenticationService, AuthenticationService>();



            _clientId = clientId;

            var authService = new AuthenticationService(clientId, apiSecret);
            //authService.AuthenticateAsync();
            //authService.AccessTokenRefreshed += authService_AccessTokenRefreshed;

            IsInitialized = true;
        }



        public Task<object> AuthenticateAsync(string username, string password)
        {
            throw new NotImplementedException();
        }


        public async Task<T> GetEndPointEntityAsync<T>(RequestBase req)
        {
            return
                await SimpleIoc.Default.GetInstance<IDataService>()
                    .GetEndPointEntityAsync<T>(req);
        }

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
