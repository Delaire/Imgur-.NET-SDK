using System.Collections.Generic;

namespace Imgur.API.Model
{
    public class Notification
    {
        public List<Reply> replies { get; set; }
        public List<Message> messages { get; set; }
    }
}