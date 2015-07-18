using System.Collections.Generic;

namespace Imgur.API.Model.Entities
{
    public class Notification
    {
        public List<Reply> replies { get; set; }
        public List<Message> messages { get; set; }
    }
}