using Domain.Interfaces.Fundamentals.Request;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Dtos.Fundamentals.Requests
{
    public class GetsRequest : BaseRequest, IGetsRequest, IPageRequest
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
