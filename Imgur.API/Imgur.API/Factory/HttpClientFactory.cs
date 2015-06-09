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


        public HttpClient CreateHttpClient(bool useGzip, int maxRequestContentBufferSize)
        {
            var handler = new HttpClientHandler()
            {
                MaxRequestContentBufferSize = maxRequestContentBufferSize
            };

            if (useGzip)
            {
                handler.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            }

            return new HttpClient(handler);
        }
    }
}
