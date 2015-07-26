namespace Imgur.API.Model.Entities
{
    public class Caption
    {
        public string id { get; set; }
        public string hash { get; set; }
        public string caption { get; set; }
        public string ups { get; set; }
        public string downs { get; set; }
        public string best_score { get; set; }
        public string parent_id { get; set; }
        public bool deleted { get; set; }
        public string datetime { get; set; }
        public string points { get; set; }
        public string author { get; set; }
        public string author_id { get; set; }
        public int deleted_meta { get; set; }
        public bool on_album { get; set; }
        public object album_cover { get; set; }
        public int best_comment { get; set; }
    }
}