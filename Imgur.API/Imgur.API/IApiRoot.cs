using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imgur.API.Model;
using Imgur.API.Model.Requests;

namespace Imgur.API
{
    public interface IApiRoot
    {
        AccessToken AccessToken { get; set; }

        event ApiRoot.AccessTokenHandler AccessTokenRefreshed;

        void Init(string apiKey, string apiSecret);
        bool IsInitialized { get; }
        bool IsLoggedIn { get; }

        Task<T> GetEndPointEntityAsync<T>(RequestBase req);
        Task<T> PostEndPointEntityAsync<T>(RequestBase req);

        Task<T> MakeQueryWithoutApiAuth<T>(RequestBase req);

        Task<AccessToken> RefreshAccessTokenAsync();
        AccessToken LoginWithAccessTokenAsync(string fragment);

        Task LogoutAsync();
    }
}
