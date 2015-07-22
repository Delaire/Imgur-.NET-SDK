using System.Collections.Generic;
using Newtonsoft.Json;

namespace Imgur.API.Model.Entities
{
    public class GalleryAlbum
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
        public string cover { get; set; }
         [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string account_url { get; set; }
         [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int account_id { get; set; }
         [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string privacy { get; set; }
         [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string layout { get; set; }
         [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int views { get; set; }
         [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string link { get; set; }
         [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int ups { get; set; }
         [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int downs { get; set; }
         [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int score { get; set; }
         [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool is_album { get; set; }
         [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object vote { get; set; }
         [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int comment_count { get; set; }
        
        //[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<CommentPreview> comment_preview { get; set; }
         
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int images_count { get; set; }
        // [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Image> images { get; set; }
    }
}