using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imgur.API.Model
{
    /// <summary>
    /// A bundle synthetizing known information about an error
    /// </summary>
    public class Error
    {
        /// <summary>
        /// The error code
        /// </summary>
        public int? Code { get; set; }

        /// <summary>
        /// The error message extracted from the error reply
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Displays the content of the error bundle
        /// </summary>
        /// <returns>The description of the error bundle</returns>
        public override string ToString()
        {
            return string.Format("Error {0}: {1}", this.Code, this.Message);
        }
    }
}
