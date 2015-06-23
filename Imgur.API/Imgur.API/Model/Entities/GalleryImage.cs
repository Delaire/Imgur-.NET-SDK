using System.Collections.Generic;
using Newtonsoft.Json;

namespace Imgur.API.Model.Entities
{

    public class GalleryImage
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string id { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string title { get; set; }
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
        public int comment_count { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<CommentPreview> comment_preview { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long bandwidth { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object vote { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string section { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string account_url { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int account_id { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int ups { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int downs { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int score { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool is_album { get; set; }

    }
}