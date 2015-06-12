using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imgur.API.Model;

namespace Imgur.API.Service
{
    /// <summary>
    /// Base class for services that make authenticated data calls
    /// </summary>
    public abstract class AuthenticatedServiceBase : HttpServiceBase
    {
        private AsyncManualResetEvent _resetEvent = new AsyncManualResetEvent();

        private bool _isRefreshingAuthToken;
        private object _lock = new object();


        private IAuthenticationService _authenticationService;
        /// <summary>
        /// Retrieves the authentication service used by this service
        /// </summary>
        /// <returns></returns>
        protected IAuthenticationService GetAuthService()
        {
            if (_authenticationService == null)
            {
                _authenticationService = IoCContainer.Instance.GetSingleton<IAuthenticationService>();
            }

            return _authenticationService;
        }

        /// <summary>
        /// Checks that there is a vaild authentication token and refreshes it if not.
        /// </summary>
        /// <returns></returns>
        protected async Task<bool> CheckAuthTokenAsync()
        {
            var authService = GetAuthService();

            //If we have a valid token, no need to refresh it.
            if (authService.TokenStatus == AccessTokenStatus.ValidToken)
            {
                return true;
            }

            bool thisThreadIsGettingToken = false;

            lock (_lock)
            {
                if (!_isRefreshingAuthToken)
                {
                    _isRefreshingAuthToken = true;
                    thisThreadIsGettingToken = true;

                    _resetEvent.Reset();
                }
            }


            if (thisThreadIsGettingToken)
            {
                try
                {
                    await authService.RefreshTokenAsync();
                }

                finally
                {
                    _resetEvent.Set();
                    _isRefreshingAuthToken = false;
                }
            }
            else
            {
                await _resetEvent.WaitAsync();
            }

            return authService.TokenStatus == AccessTokenStatus.ValidToken;
        }


        protected async Task<bool> ForceRefreshAuthTokenAsync()
        {
            var authService = GetAuthService();

            bool thisThreadIsGettingToken = false;

            lock (_lock)
            {
                if (!_isRefreshingAuthToken)
                {
                    _isRefreshingAuthToken = true;
                    thisThreadIsGettingToken = true;

                    _resetEvent.Reset();
                }
            }


            if (thisThreadIsGettingToken)
            {
                try
                {
                    await authService.RefreshTokenAsync();
                }

                finally
                {
                    _resetEvent.Set();
                    _isRefreshingAuthToken = false;
                }
            }
            else
            {
                await _resetEvent.WaitAsync();
            }

            return authService.TokenStatus == AccessTokenStatus.ValidToken;
        }


    }
}

