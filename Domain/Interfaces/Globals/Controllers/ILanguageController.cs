using Domain.Interfaces.Fundamentals.Controller;
using Domain.Models.Dtos.Requests.Languages;

namespace Domain.Interfaces.Globals.Controllers
{
    public interface ILanguageController : IController<AddLanguageRequest, EditLanguageRequest, DeleteLanguageRequest>,
                                           IGetController<GetLanguageRequest, GetLanguagesRequest>
    {
       
    }
}
