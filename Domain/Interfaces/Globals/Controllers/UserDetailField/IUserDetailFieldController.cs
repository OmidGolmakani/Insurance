using Domain.Interfaces.Fundamentals.Controller;
using Domain.Models.Dtos.Requests.UserDetailFields;

namespace Domain.Interfaces.Globals.Controllers
{
    public interface IUserDetailFieldController : IController<AddUserDetailFieldRequest, EditUserDetailFieldRequest, DeleteUserDetailFieldRequest>,
                                                  IGetController<GetUserDetailFieldRequest, GetUserDetailFieldsRequest>
    {
    }
}
