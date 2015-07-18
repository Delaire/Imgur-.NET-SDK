using System.Collections.Generic;

namespace Imgur.API.Model.Entities
{
    public class GalleryAlbum
    {
        public string id { get; set; }
        public string title { get; set; }
        public object description { get; set; }
        public int datetime { get; set; }
        public string cover { get; set; }
        public string account_url { get; set; }
        public int account_id { get; set; }
        public string privacy { get; set; }
        public string layout { get; set; }
        public int views { get; set; }
        public string link { get; set; }
        public int ups { get; set; }
        public int downs { get; set; }
        public int score { get; set; }
        public bool is_album { get; set; }
        public object vote { get; set; }
        public int comment_count { get; set; }
        public List<CommentPreview> comment_preview { get; set; }
        public int images_count { get; set; }
        public List<Image> images { get; set; }
    }
}