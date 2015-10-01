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
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<CommentPreview> comment_preview { get; set; }
         
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int images_count { get; set; }
         [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Image> images { get; set; }
    }



    //public class GalleryAlbumData
    //{

    //    public string id { get; set; }
    //    public string title { get; set; }
    //    public object description { get; set; }
    //    public int datetime { get; set; }
    //    public string cover { get; set; }
    //    public int cover_width { get; set; }
    //    public int cover_height { get; set; }
    //    public string account_url { get; set; }
    //    public int account_id { get; set; }
    //    public string privacy { get; set; }
    //    public string layout { get; set; }
    //    public int views { get; set; }
    //    public string link { get; set; }
    //    public int ups { get; set; }
    //    public int downs { get; set; }
    //    public int score { get; set; }
    //    public bool is_album { get; set; }
    //    public object vote { get; set; }
    //    public bool favorite { get; set; }
    //    public bool nsfw { get; set; }
    //    public string section { get; set; }
    //    public int comment_count { get; set; }
    //    public List<CommentPreview> comment_preview { get; set; }
    //    public string topic { get; set; }
    //    public int topic_id { get; set; }
    //    public int images_count { get; set; }
    //    public List<Image> images { get; set; }
    //}

}