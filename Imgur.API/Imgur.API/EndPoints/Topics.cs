using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imgur.API.Model.Requests;
using System.Net.Http;

namespace Imgur.API.EndPoints
{
    public class GetTopics : RequestBase
    {
        public override string CallIdentifier
        {
            get { return string.Format("topics/defaults"); }
        }
    }
}
