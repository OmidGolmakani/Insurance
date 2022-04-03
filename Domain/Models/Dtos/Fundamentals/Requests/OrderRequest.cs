using Domain.Interfaces.Fundamentals.Request;
using Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Dtos.Fundamentals.Requests
{
    public class OrderRequest : IOrderRequest
    {
        public string Column { get; set; }
        public Order.OrderType OrderType { get; set; }
    }
}
