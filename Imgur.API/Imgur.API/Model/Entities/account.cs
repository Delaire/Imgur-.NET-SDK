using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imgur.API.Model
{
    public class Account
    {
        public int id { get; set; }
        public string url { get; set; }
        public string bio { get; set; }
        public double reputation { get; set; }
        public int created { get; set; }
        public bool pro_expiration { get; set; }
    }
}
