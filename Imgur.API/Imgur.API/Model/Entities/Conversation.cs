namespace Imgur.API.Model.Entities
{
    public class Conversation
    {
        public int id { get; set; }
        public string with_account { get; set; }
        public int with_account_id { get; set; }
        public string last_message_preview { get; set; }
        public int message_count { get; set; }
        public int datetime { get; set; }
    }
}