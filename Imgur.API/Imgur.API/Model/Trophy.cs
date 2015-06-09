namespace Imgur.API.Model
{
    public class Trophy
    {
        public int id { get; set; }
        public string name { get; set; }
        public string name_clean { get; set; }
        public string description { get; set; }
        public object data { get; set; }
        public object data_link { get; set; }
        public int datetime { get; set; }
        public string image { get; set; }
    }
}