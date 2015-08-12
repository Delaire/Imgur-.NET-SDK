using System;
using System.Net.Http;

namespace Imgur.API.Model.Requests
{
    public abstract class RequestBase
    {
        public HttpMethod Method { get; set; }

        /// <summary>
        /// Global Parameter
        /// string get Url To Call
        /// </summary>
        public abstract string CallIdentifier { get; }

        public bool IsLoginRequired { get; set; }

        internal virtual string CacheKey
        {
            get
            {
                if (CallIdentifier != null)
                {
                    return String.Format("{0}:{1}", DateTime.Now.TimeOfDay.ToString(), CallIdentifier);
                }

                return "";
            }
        }


    }
}
