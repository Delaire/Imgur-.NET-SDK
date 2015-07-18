using Imgur.API.Model.Entities;

namespace Imgur.API.Model
{
    public class Reply
    {
        public int id { get; set; }
        public int account_id { get; set; }
        public bool viewed { get; set; }
        public Content content { get; set; }
    }
}