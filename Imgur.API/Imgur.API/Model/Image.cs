namespace Imgur.API.Model
{
    public class Image
    {
        public string id { get; set; }
        public object title { get; set; }
        public object description { get; set; }
        public int datetime { get; set; }
        public string type { get; set; }
        public bool animated { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int size { get; set; }
        public int views { get; set; }
        public object bandwidth { get; set; }
        public string link { get; set; }
    }
}