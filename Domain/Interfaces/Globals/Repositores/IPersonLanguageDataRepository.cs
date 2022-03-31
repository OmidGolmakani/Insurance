using Domain.Interfaces.Fundamentals.Repository;
using Domain.Models.Dtos.Requests.PersonLanguageDatas;
using Domain.Models.Dtos.Responses.PersonLanguageDatas;
using Domain.Models.Entities;

namespace Domain.Interfaces.Globals.Repositories
{
    public interface IPersonLanguageDataRepository : IRepository<long,
                                                                 PersonLanguageData,
                                                                 GetPersonLanguageDataRequest,
                                                                 GetPeopleLanguageDataRequest,
                                                                 PersonLanguageDataResponse>
    {

    }
}
