using System.Collections.Generic;
using Imgur.API.Model.Entities;

namespace Imgur.API.Model
{
    public class Tag
    {
        public int ups { get; set; }
        public int downs { get; set; }
        public string name { get; set; }
        public string author { get; set; }
    }

    public class Tag<T>
    {
        public string name { get; set; }
        public int followers { get; set; }
        public int total_items { get; set; }
        public List<Following> following { get; set; }
        public List<T> items { get; set; }
    }
}