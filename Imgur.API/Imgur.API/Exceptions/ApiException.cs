using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imgur.API.Model;

namespace Imgur.API.Exceptions
{
    /// <summary>
    /// An exception thrown by the Imgur .NET SDK
    /// </summary>
    public class ApiException : Exception
    {
        /// <summary>
        /// Type of the exception. Indicates a general root cause for the error
        /// </summary>
        public ApiExceptionType Type { get; private set; }

        /// <summary>
        /// Constructor for ApiException
        /// </summary>
        /// <param name="message">Message to contain in the exception</param>
        /// <param name="type">Type of the exception</param>
        public ApiException(string message, ApiExceptionType type)
            : base(message)
        {
            Type = type;
        }

        /// <summary>
        /// Constructor for ApiException
        /// </summary>
        /// <param name="message">Message to contain in the exception</param>
        /// <param name="innerException">Inner exception</param>
        /// <param name="type">Type of the exception</param>
        public ApiException(string message, Exception innerException, ApiExceptionType type)
            : base(message, innerException)
        {
            Type = type;
        }
    }
}
