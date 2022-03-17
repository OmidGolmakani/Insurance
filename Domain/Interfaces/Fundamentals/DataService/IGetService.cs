using Domain.Models.Dtos.Fundamentals.Response;
using System.Threading.Tasks;

namespace Domain.Interfaces.Fundamentals.DataService
{
    public interface IGetService<TGetRequest, TGetsRequest, TResponse> where TGetRequest : class
                                                                       where TGetsRequest : class
                                                                       where TResponse : class
    {
        Task<TResponse> GetAsync(TGetRequest request, bool includeDeleted = false);
        Task<ListResponse<TResponse>> GetsAsync(TGetsRequest request, bool includeDeleted = false);
        Task<int> CountAsync(TGetsRequest request, bool includeDeleted = false);
    }
}
