using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domain.Models.Enums.Order;

namespace Domain.Interfaces.Fundamentals.Request
{
    public interface IOrderRequest
    {
        string Column { get; set; }
        OrderType OrderType { get; set; }
    }
}
