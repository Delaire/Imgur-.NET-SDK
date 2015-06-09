using System.Collections.Generic;

namespace Imgur.API.Model
{
    public class GalleryImage
    {
        public string id { get; set; }
        public string title { get; set; }
        public object description { get; set; }
        public int datetime { get; set; }
        public string type { get; set; }
        public bool animated { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int size { get; set; }
        public int views { get; set; }
        public int comment_count { get; set; }
        public List<CommentPreview> comment_preview { get; set; }
        public long bandwidth { get; set; }
        public object vote { get; set; }
        public string section { get; set; }
        public string account_url { get; set; }
        public int account_id { get; set; }
        public int ups { get; set; }
        public int downs { get; set; }
        public int score { get; set; }
        public bool is_album { get; set; }
    }
}