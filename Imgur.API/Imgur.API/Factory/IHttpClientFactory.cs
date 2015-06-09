using System.Net.Http;

namespace Imgur.API.Factory
{
    /// <summary>
    /// Interface defining a factory for creating HttpClients for use in Http services. For use with unit testing.
    /// </summary>
    public interface IHttpClientFactory
    {
        /// <summary>
        /// Create an HTTP client with default settings
        /// </summary>
        /// <returns></returns>
        HttpClient CreateHttpClient();

        /// <summary>
        /// Create an HTTP client with some custom settings
        /// </summary>
        /// <param name="useGzip">TRUE to use Gzip for the client, FALSE otherwise</param>
        /// <param name="maxRequestContentBufferSize">Maximum buffer size for the _request content</param>
        /// <returns></returns>
        HttpClient CreateHttpClient(bool useGzip, int maxRequestContentBufferSize);
    }
}
