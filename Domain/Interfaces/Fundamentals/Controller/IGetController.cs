using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Fundamentals.Controller
{
    public interface IGetController<TGetRequest, TGetsRequest>
    {
        Task<IActionResult> Get(TGetRequest request, bool includeDeleted = false);
        Task<IActionResult> Gets(TGetsRequest request, bool includeDeleted = false);

    }
}
