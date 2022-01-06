using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Fundamentals.Repository
{
    public interface IGetRepository<TGetRequest, TGetsRequest, TResponse>
    {
        Task<TResponse> GetById(TGetRequest request, bool includeDeleted = false);
        Task<IEnumerable<TResponse>> Get(TGetsRequest request, bool includeDeleted = false);
        Task<int> Count(TGetsRequest request, bool includeDeleted = false);
    }
}
