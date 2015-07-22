using System.Collections.Generic;

namespace Imgur.API.Model.Entities
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

    public class DataCaption
    {
        public object image { get; set; }
        public List<Caption> captions { get; set; }
    }

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

    //public class QueryComment
    //{
    //    public int id { get; set; }
    //    public string image_id { get; set; }
    //    public string comment { get; set; }
    //    public string author { get; set; }
    //    public int author_id { get; set; }
    //    public bool on_album { get; set; }
    //    public object album_cover { get; set; }
    //    public int ups { get; set; }
    //    public int downs { get; set; }
    //    public int points { get; set; }
    //    public int datetime { get; set; }
    //    public int parent_id { get; set; }
    //    public bool deleted { get; set; }
    //    public object vote { get; set; }
    //    public List<object> children { get; set; }
    //}

}