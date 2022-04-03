using Domain.Interfaces.Fundamentals.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Dtos.Fundamentals.Requests
{
    public class ListOrderRequest : BaseRequest
    {
        public List<OrderRequest> Orders { get; set; } = new();
    }
}
