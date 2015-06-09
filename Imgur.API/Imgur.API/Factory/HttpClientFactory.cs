using System.Net;
using System.Net.Http;

namespace Imgur.API.Factory
{
    public class HttpClientFactory : IHttpClientFactory
    {
        public System.Net.Http.HttpClient CreateHttpClient()
        {
            return new HttpClient(
                        new HttpClientHandler() { AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip }
                        );
        }
    }
}
