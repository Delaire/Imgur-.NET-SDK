using System.Collections.Generic;

namespace Imgur.API.Model
{
    public class CommentPreview
    {
        public int id { get; set; }
        public string image_id { get; set; }
        public string comment { get; set; }
        public string author { get; set; }
        public int author_id { get; set; }
        public bool on_album { get; set; }
        public string album_cover { get; set; }
        public int ups { get; set; }
        public int downs { get; set; }
        public int points { get; set; }
        public int datetime { get; set; }
        public int parent_id { get; set; }
        public bool deleted { get; set; }
        public string vote { get; set; }
        public List<Comment> children { get; set; }
    }
}