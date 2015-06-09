using System.Collections.Generic;

namespace Imgur.API.Model
{
    public class Content
    {
        public object album_cover { get; set; }
        public string author { get; set; }
        public int author_id { get; set; }
        public List<object> children { get; set; }
        public string comment { get; set; }
        public int datetime { get; set; }
        public bool deleted { get; set; }
        public int downs { get; set; }
        public int id { get; set; }
        public string image_id { get; set; }
        public bool on_album { get; set; }
        public int parent_id { get; set; }
        public int points { get; set; }
        public int ups { get; set; }
        public object vote { get; set; }
    }
}