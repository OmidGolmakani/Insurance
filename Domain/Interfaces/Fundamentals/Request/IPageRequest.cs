using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Fundamentals.Request
{
    public interface IPageRequest
    {
        int PageIndex { get; set; }
        int PageSize { get; set; }
    }
}
