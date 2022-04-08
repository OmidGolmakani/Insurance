using Domain.Interfaces.Fundamentals.Repository;
using Domain.Models.Dtos.Requests.UserDetailFieldLanguageDatas;
using Domain.Models.Dtos.Responses.UserDetailFieldLanguageDatas;
using Domain.Models.Entities;

namespace Domain.Interfaces.Globals.Repositories
{
    public interface IUserDetailFieldLanguageDataRepository : IRepository<long,
                                                                          UserDetailFieldLanguageData,
                                                                          GetUserDetailFieldLanguageDataRequest,
                                                                          GetUserDetailFieldsLanguageDataRequest,
                                                                          UserDetailFieldLanguageDataResponse>
    {

    }
}
