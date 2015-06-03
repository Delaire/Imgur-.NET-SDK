using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



        public object AccessToken
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public void Init(string apiKey, string apiSecret)
        {
            //var authService = new AuthenticationService(apiKey, apiSecret);
            ////authService.RefreshTokenAsync();
            //authService.AccessTokenRefreshed += authService_AccessTokenRefreshed;

            IsInitialized = true;
        }

        

        public Task<object> AuthenticateAsync(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
