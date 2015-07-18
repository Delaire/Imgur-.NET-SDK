namespace Imgur.API.Model.Entities
{
    public class Topic
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string css { get; set; }
        public bool ephemeral { get; set; }
    }
}