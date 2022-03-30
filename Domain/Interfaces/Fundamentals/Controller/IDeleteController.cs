using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Fundamentals.Controller
{
    public interface IDeleteController<TDeleteRequest>
    {
        Task<IActionResult> Delete(TDeleteRequest request);
        Task<IActionResult> BachDelete(IList<TDeleteRequest> request);
    }
}
