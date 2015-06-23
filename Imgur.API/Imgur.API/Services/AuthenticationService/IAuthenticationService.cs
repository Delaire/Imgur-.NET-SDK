using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imgur.API.Model;

namespace Imgur.API.Service
{
    public interface IAuthenticationService
    {
        AccessToken AccessToken { get; set; }

        Task<AccessToken> AuthenticateAsync(string username, string password);

        Task<AccessToken> AuthenticateAsync();

        Task<AccessToken> RefreshTokenAsync();

        Task LogoutAsync();

        AccessTokenStatus TokenStatus { get; }
    }
}
