using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imgur.API.Model;

namespace Imgur.API
{
    public interface IApiRoot
    {
        AccessToken AccessToken { get; set; }
       

        void Init(string apiKey, string apiSecret);
        bool IsInitialized { get; }
        bool IsLoggedIn { get; set; }

        Task<object> RefreshTokenAsync(string username, string password);
      
    }
}
