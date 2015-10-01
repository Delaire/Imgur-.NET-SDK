using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imgur.API.Model;

namespace Imgur.API.Exceptions
{
    /// <summary>
    /// An exception representing an error that occurred on the server
    /// </summary>
    public class ServerErrorApiException : ApiException
    {
        /// <summary>
        /// Constructor for ServerErrorApiException
        /// </summary>
        /// <param name="error">the deserialized JSON error returned from the server</param>
        internal ServerErrorApiException(Error error) :
            base(error.Message, ApiExceptionType.ServerError)
        {
            Error = error;
        }

        /// <summary>
        /// The deserialized JSON error returned from the server
        /// </summary>
        public Error Error { get; private set; }
    }
}
