using Domain.Interfaces.Fundamentals.Request;

namespace Domain.Models.Dtos.Fundamentals.Requests
{
    public class GetsRequest : BaseRequest, IGetsRequest, IPageRequest
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
