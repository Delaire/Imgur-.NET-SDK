using System;
using Imgur.API.Model;

namespace Imgur.API.Services.AuthenticationService
{
    public class AccessTokenEventArgs : EventArgs
    {
        public AccessTokenEventArgs(AccessToken token)
        {
            Token = token;
        }

        public AccessToken Token { get; private set; }
    }
}
