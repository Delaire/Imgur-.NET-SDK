using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imgur.API.Model
{
    public enum AccessTokenStatus
    {
        NoToken,
        ValidToken,
        TokenExpired
    }
}
