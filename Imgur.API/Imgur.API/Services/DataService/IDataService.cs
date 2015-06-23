using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imgur.API.Model.Requests;

namespace Imgur.API.Service.DataService
{
    public interface IDataService
    {
        Task<T> MakeRequest<T>(RequestBase req);

        Task<T> GetEndPointEntityAsync<T>(RequestBase req);
        Task<TTarget> GetEndPointEntityAsync<TSource, TTarget>(RequestBase req, object Entity);
    }
}
