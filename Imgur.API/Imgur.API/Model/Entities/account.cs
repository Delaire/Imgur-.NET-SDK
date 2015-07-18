namespace Imgur.API.Model.Entities
{
    public class Account
    {
        public int id { get; set; }
        public string url { get; set; }
        public string bio { get; set; }
        public double reputation { get; set; }
        public int created { get; set; }
        public bool pro_expiration { get; set; }
    }
}
