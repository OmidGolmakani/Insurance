using Domain.Interfaces.Fundamentals.DataService;
using Domain.Models.Dtos.Requests.UserDetailFields;
using Domain.Models.Dtos.Responses.UserDetailFields;
using Domain.Models.Entities;

namespace Domain.Interfaces.Globals.DataServices
{
    public interface IUserDetailFieldService : IService<long,
                                               UserDetailField,
                                               AddUserDetailFieldRequest,
                                               EditUserDetailFieldRequest,
                                               DeleteUserDetailFieldRequest,
                                               GetUserDetailFieldRequest,
                                               GetUserDetailFieldsRequest,
                                               UserDetailFieldResponse>
    {

    }
}
