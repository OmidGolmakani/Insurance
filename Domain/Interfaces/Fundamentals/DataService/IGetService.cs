using Domain.Dtos.Fundamentals.Response;
using System.Threading.Tasks;

namespace Domain.Interfaces.Fundamentals.DataService
{
    public interface IGetService<TGetRequest, TGetsRequest, TResponse> where TGetRequest : class
                                                                       where TGetsRequest : class
                                                                       where TResponse : class
    {
        Task<TResponse> GetAsync(TGetRequest request);
        Task<ListResponse<TResponse>> GetsAsync(TGetsRequest request);
        Task<int> CountAsync(TGetsRequest request);
    }
}
