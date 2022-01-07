using Domain.Interfaces.Fundamentals.Controller;
using Domain.Models.Dtos.Requests.Users;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Domain.Interfaces.Globals.Controllers
{
    public interface IUserController : IController<AddUserRequest, EditUserRequest, DeleteUserRequest>,
                                       IGetController<GetUserRequest, GetUsersRequest>
    {
        Task GetPhoneNumberVerification(GetUserRequest request);
        Task GetEmailVerification(GetUserRequest request);
        Task<IActionResult> SigninAsync(LoginRequst requst);
        Task SignoutAsync();
    }
}
