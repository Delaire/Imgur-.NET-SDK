using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imgur.API.Service.DataService
{
    public interface IDataService
    {
        Task<T> MakeRequest<T>(RequestBase req);
    }
}
