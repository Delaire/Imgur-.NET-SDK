namespace Imgur.API.Model.Entities
{
    public class AutoComplete
    {
        public string type { get; set; }
        public string text { get; set; }
        public int images { get; set; }
        public double score { get; set; }
    }
}