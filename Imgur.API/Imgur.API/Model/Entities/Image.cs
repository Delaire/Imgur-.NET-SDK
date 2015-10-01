using Newtonsoft.Json;

namespace Imgur.API.Model.Entities
{
    public class Image
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string id { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string title { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string description { get; set; }
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
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string gifv { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string webm { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string mp4 { get; set; }





    }
}