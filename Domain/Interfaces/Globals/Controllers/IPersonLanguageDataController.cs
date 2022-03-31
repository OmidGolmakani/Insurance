using Domain.Interfaces.Fundamentals.Controller;
using Domain.Models.Dtos.Requests.PersonLanguageDatas;

namespace Domain.Interfaces.Globals.Controllers
{
    public interface IIPersonLanguageDataController : IGetController<GetPersonLanguageDataRequest, 
                                                                     GetPeopleLanguageDataRequest>,
                                                      IDeleteController<DeletePersonLanguageDataRequest>
    {

    }
}
