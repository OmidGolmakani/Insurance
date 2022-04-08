using Domain.Interfaces.Fundamentals.DataService;
using Domain.Models.Dtos.Requests.UserDetailFieldLanguageDatas;
using Domain.Models.Dtos.Responses.UserDetailFieldLanguageDatas;
using Domain.Models.Entities;

namespace Domain.Interfaces.Globals.DataServices
{
    public interface IUserDetailFieldLanguageDataService : IService<long,
                                                           UserDetailFieldLanguageData,
                                                           AddUserDetailFieldLanguageDataRequest,
                                                           EditUserDetailFieldLanguageDataRequest,
                                                           DeleteUserDetailFieldLanguageDataRequest,
                                                           GetUserDetailFieldLanguageDataRequest,
                                                           GetUserDetailFieldsLanguageDataRequest,
                                                           UserDetailFieldLanguageDataResponse>
    {

    }
}
