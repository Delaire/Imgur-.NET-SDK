using System.Collections.Generic;
using Imgur.API.Model.Entities;
using Newtonsoft.Json;

namespace Imgur.API.Model
{
    public class CommentPreview
    {
          [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int id { get; set; }
       [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string image_id { get; set; }
          [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string comment { get; set; }
          [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string author { get; set; }
          [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int author_id { get; set; }
          [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool on_album { get; set; }
          [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string album_cover { get; set; }
          [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int ups { get; set; }
          [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int downs { get; set; }
          [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int points { get; set; }
          [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int datetime { get; set; }
          [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int parent_id { get; set; }
          [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool deleted { get; set; }
          [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string vote { get; set; }
        // [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Comment> children { get; set; }

    }
}