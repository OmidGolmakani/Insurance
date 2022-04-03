using Domain.Interfaces.Fundamentals.Request;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Dtos.Fundamentals.Requests
{
    public class GetsRequest : BaseRequest, IGetsRequest, IPageRequest
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public List<OrderRequest> Orders { get; set; } = new();
    }
}
