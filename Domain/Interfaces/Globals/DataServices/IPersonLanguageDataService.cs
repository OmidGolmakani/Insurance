using Domain.Interfaces.Fundamentals.DataService;
using Domain.Models.Dtos.Requests.PersonLanguageDatas;
using Domain.Models.Dtos.Responses.People;
using Domain.Models.Dtos.Responses.PersonLanguageDatas;
using Domain.Models.Entities;

namespace Domain.Interfaces.Globals.DataServices
{
    public interface IPersonLanguageDataService : IService<long,
                                                          PersonLanguageData,
                                                          AddPersonLanguageDataRequest,
                                                          EditPersonLanguageDataRequest,
                                                          DeletePersonLanguageDataRequest,
                                                          GetPersonLanguageDataRequest,
                                                          GetPeopleLanguageDataRequest,
                                                          PersonLanguageDataResponse>
    {

    }
}
