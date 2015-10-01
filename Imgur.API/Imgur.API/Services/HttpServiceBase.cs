using System.Net.Http;
using GalaSoft.MvvmLight.Ioc;
using Imgur.API.Factory;

namespace Imgur.API.Service
{
    /// <summary>
    /// Base class for services that make HTTP requests
    /// </summary>
    public abstract class HttpServiceBase
    {
        private HttpClient _httpClient;
        internal HttpClient HttpClient
        {
            get
            {
                if (_httpClient == null)
                {
                    _httpClient = CreateNewHttpClient();
                }

                return _httpClient;
            }
            set
            {
                _httpClient = value;
            }
        }

        /// <summary>
        /// Creates a new HTTP client with default settings
        /// </summary>
        /// <returns>The newly created client</returns>
        protected HttpClient CreateNewHttpClient()
        {
            var factory = SimpleIoc.Default.GetInstance<IHttpClientFactory>();

            return factory.CreateHttpClient();

        }
    }
}
