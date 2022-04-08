using Domain.Interfaces.Fundamentals.Controller;
using Domain.Models.Dtos.Requests.UserDetailFieldLanguageDatas;

namespace Domain.Interfaces.Globals.Controllers
{
    public interface IUserDetailFieldLanguageDataController : IGetController<GetUserDetailFieldLanguageDataRequest,
                                                                             GetUserDetailFieldsLanguageDataRequest>,
                                                              IDeleteController<DeleteUserDetailFieldLanguageDataRequest>
    {

    }
}
