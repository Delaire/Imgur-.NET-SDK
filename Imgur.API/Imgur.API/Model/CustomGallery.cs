using System.Collections.Generic;

namespace Imgur.API.Model
{
    public class CustomGallery<T>
    {
        public string link { get; set; }
        public List<string> tags { get; set; }
        public string account_url { get; set; }
        public List<T> items { get; set; }
    }
}