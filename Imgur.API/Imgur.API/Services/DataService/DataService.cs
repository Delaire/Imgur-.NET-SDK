using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Imgur.API.EndPoints.Gallery;
using Imgur.API.Exceptions;
using Imgur.API.Model;
using Imgur.API.Model.Requests;
using Imgur.API.Service;
using Imgur.API.Service.DataService;
using Newtonsoft.Json;

namespace Imgur.API.Services.DataService
{
    public class DataService : AuthenticatedServiceBase, IDataService
    {
        /// <summary>
        /// Makes a request to the Imgur API
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="req"></param>
        /// <returns>Json Content</returns>
        public async Task<T> MakeRequest<T>(RequestBase req)
        {
            if (req == null)
            {
                throw new ArgumentNullException("req");
            }
            //Check if query requires to be login user has login token
            if (req.IsLoginRequired)
            {
                //Refresh the token if needed
                if (!await CheckAuthTokenAsync())
                {
                    throw new ApiException("Could not obtain authorization to access Imgur Logged services", ApiExceptionType.NotAuthorized);
                }
            }

            ////TODO: see if we dont have this element already cached
            //var cachedEntity = await CheckCacheForRequestAsync<T>(req);

            //if (cachedEntity != null)
            //{
            //    return cachedEntity;
            //}

            //Do we need to send Aouth Token? yes if user is logged
            var message = PrepareMessage(req);

            var response = await HttpClient.SendAsync(message);

            if (response == null)
            {
                throw new ApiException("The server did not return a response.", ApiExceptionType.NoServerResponse);
            }

            if (response.IsSuccessStatusCode)
            {
                if (response.Content == null)
                {
                    throw new ApiException("The server returned an empty response.", ApiExceptionType.NoServerResponse);
                }

                var responseJson = await response.Content.ReadAsStringAsync();

                if (String.IsNullOrEmpty(responseJson))
                {
                    throw new ApiException("The server returned an empty response.", ApiExceptionType.NoServerResponse);
                }

                object responseObject;
                try
                {
                    responseObject = JsonConvert.DeserializeObject<T>(responseJson);
                }
                catch (ServerErrorApiException)
                {
                    throw;
                }
                catch (Exception ex)
                {
                    throw new ApiException("The server did not return a response in the expected format.", ex, ApiExceptionType.InvalidServerResponse);
                }

                return (T)responseObject;
            }
            else
            {
                var errorMsg = String.Format("The server returned status code {0} with error {1}",
                    response.StatusCode, response.ReasonPhrase);

                throw new ApiException(errorMsg, ApiExceptionType.ServerError);
            }
        }

        public async Task<T> GetEndPointEntityAsync<T>(RequestBase request)
        {
            request.Method = HttpMethod.Get;

            return await MakeRequest<T>(request);
        }


        public async Task<T> PostEndPointEntityAsync<T>(RequestBase request)
        {
            request.Method = HttpMethod.Post;

            return await MakeRequest<T>(request);
        }



        public async Task<object> MakeQueryWithoutApiAuth<T>(RequestBase request)
        {
            //string url = request.CallIdentifier;

            var message = new HttpRequestMessage(HttpMethod.Get, request.CallIdentifier);

            var response = await HttpClient.SendAsync(message);

            if (response.IsSuccessStatusCode)
            {
                if (response.Content == null)
                {
                    throw new ApiException("The server returned an empty response.", ApiExceptionType.NoServerResponse);
                }

                var responseJson = await response.Content.ReadAsStringAsync();

                if (String.IsNullOrEmpty(responseJson))
                {
                    throw new ApiException("The server returned an empty response.", ApiExceptionType.NoServerResponse);
                }

                object responseObject;
                try
                {
                    responseObject = JsonConvert.DeserializeObject<T>(responseJson);
                }
                catch (ServerErrorApiException)
                {
                    throw;
                }
                catch (Exception ex)
                {
                    throw new ApiException("The server did not return a response in the expected format.", ex, ApiExceptionType.InvalidServerResponse);
                }

                return (T)responseObject;
            }

            return null;
        }





        public Task<TTarget> GetEndPointEntityAsync<TSource, TTarget>(RequestBase req, object Entity)
        {
            throw new NotImplementedException();
        }


        private HttpRequestMessage PrepareMessage(RequestBase req)
        {
            string url = String.Format("{0}{1}",
                Constants.URL_BASEAPI,
                req.CallIdentifier
                );

            if (req.IsLoginRequired)
            {
                url = String.Format("{0}?oauth_token={1}", url, GetAuthService().AccessToken.Token);
            }

            //Creating query
            var message = new HttpRequestMessage(req.Method, url);

            if (req.Method == HttpMethod.Post)
            {
                //adding post Query
                message.Content = new StringContent((req as PostRequestBase).CallPostMessage);
            }

         

            //var message = new HttpRequestMessage(HttpMethod.Post, url)
            //{
            //    Content = new StringContent(json)
            //};

            message.Headers.TryAddWithoutValidation("Authorization", "Client-ID " + ApiRoot.Instance.ClientId);

            return message;
        }

        //private HttpRequestMessage PrepareOAuthMessage(RequestBase req)
        //{
        //    string url = String.Format("{0}{1}?oauth_token={2}",
        //        Constants.URL_BASEAPI,
        //        req.CallIdentifier,
        //        GetAuthService().AccessToken.Token);

        //    var message = new HttpRequestMessage(req.Method, url);

        //    return message;
        //}

    }
}
