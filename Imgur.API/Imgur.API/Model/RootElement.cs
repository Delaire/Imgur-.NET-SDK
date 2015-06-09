using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imgur.API.Model
{
    public class RootElement<T>
    {
        public T data { get; set; }
        public int status { get; set; }
        public bool success { get; set; }
    }
}
