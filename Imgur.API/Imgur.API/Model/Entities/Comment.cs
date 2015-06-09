namespace Imgur.API.Model
{
    public class Comment
    {
        public int id { get; set; }
        public string image_id { get; set; }
        public string caption { get; set; }
        public string author { get; set; }
        public int author_id { get; set; }
        public bool on_album { get; set; }
        public object album_cover { get; set; }
        public int ups { get; set; }
        public int downs { get; set; }
        public int points { get; set; }
        public int datetime { get; set; }
        public object parent_id { get; set; }
        public bool deleted { get; set; }
    }
}