using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Imgur.API.EndPoints
{
    public class BasicEndPointOptions
    {
        private int _page = Constants.PAGED_REQUEST_DEFAULT_PAGE;

        /// <summary>
        /// The page number to load
        /// </summary>
        [JsonProperty(PropertyName = "Page", NullValueHandling = NullValueHandling.Ignore)]
        public int Page
        {
            get { return _page; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("value");
                }

                _page = value;
            }
        }

        
        [JsonProperty(PropertyName = "section", NullValueHandling = NullValueHandling.Ignore)]
        public string Section { get; set; }

        [JsonProperty(PropertyName = "sort", NullValueHandling = NullValueHandling.Ignore)]
        public string sort { get; set; }

         [JsonProperty(PropertyName = "window", NullValueHandling = NullValueHandling.Ignore)]
        public string window { get; set; }


        [JsonProperty(PropertyName = "showViral", NullValueHandling = NullValueHandling.Ignore)]
        public bool showViral { get; set; }

    }
}
