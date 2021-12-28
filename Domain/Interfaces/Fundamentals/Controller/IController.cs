using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Fundamentals.Controller
{
    public interface IController<TAddRequest, TEditRequest, TDeleteRequest>
    {
        Task<IActionResult> Post(TAddRequest request);
        Task<IActionResult> Put(TEditRequest request);
        Task<IActionResult> Delete(TDeleteRequest request);
        Task<IActionResult> BachDelete(IList<TDeleteRequest> request);
    }
}
