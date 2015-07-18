using System.Collections.Generic;

namespace Imgur.API.Model.Entities
{
    public class AccountSettings
    {
        public string email { get; set; }
        public bool high_quality { get; set; }
        public bool public_images { get; set; }
        public string album_privacy { get; set; }
        public bool pro_expiration { get; set; }
        public bool accepted_gallery_terms { get; set; }
        public List<object> active_emails { get; set; }
        public bool messaging_enabled { get; set; }
        public List<BlockedUser> blocked_users { get; set; }
    }
}