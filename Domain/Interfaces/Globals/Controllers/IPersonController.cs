using Domain.Interfaces.Fundamentals.Controller;
using Domain.Models.Dtos.Requests.People;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Domain.Interfaces.Globals.Controllers
{
    public interface IPersonController : IController<AddPersonRequest, EditPersonRequest, DeletePersonRequest>,
                                         IGetController<GetPersonRequest, GetPeopleRequest>
    {
        Task<IActionResult> GetGenders();
    }
}
