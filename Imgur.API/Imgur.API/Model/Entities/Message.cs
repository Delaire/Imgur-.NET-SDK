using Imgur.API.Model.Entities;

namespace Imgur.API.Model
{
    public class Message
    {
        public int id { get; set; }
        public int account_id { get; set; }
        public bool viewed { get; set; }
        public Content2 content { get; set; }
    }
}