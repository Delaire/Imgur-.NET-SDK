using System.Collections.Generic;

namespace Imgur.API.Model.Entities
{
    public class RootElement<T>
    {
        public IList<T> data { get; set; }
        public int status { get; set; }
        public bool success { get; set; }
    }
}
