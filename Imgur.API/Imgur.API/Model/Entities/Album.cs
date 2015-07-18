using System.Collections.Generic;

namespace Imgur.API.Model.Entities
{
    public class Album
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
        public int images_count { get; set; }
        public List<Image> images { get; set; }
    }
}