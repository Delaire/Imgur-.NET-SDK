using Newtonsoft.Json;

namespace Imgur.API.Model.Entities
{
    public class Image
    {
          [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string id { get; set; }
          [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object title { get; set; }
          [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object description { get; set; }
          [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int datetime { get; set; }
          [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string type { get; set; }
          [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool animated { get; set; }
          [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int width { get; set; }
          [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int height { get; set; }
          [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int size { get; set; }
          [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int views { get; set; }
          [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object bandwidth { get; set; }
          [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string link { get; set; }

    }
}