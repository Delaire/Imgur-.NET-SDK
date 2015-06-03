using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imgur.API
{
    public interface IApiRoot
    {
        object AccessToken { get; set; }
        //event ApiRoot.AccessTokenHandler AccessTokenRefreshed;

        void Init(string apiKey, string apiSecret);
        bool IsInitialized { get; }

        Task<object> AuthenticateAsync(string username, string password);
      
    }
}
