using Domain.Interfaces.Fundamentals.DataService;
using Domain.Models.Dtos.Requests.Users;
using Domain.Models.Dtos.Responses.Users;
using Domain.Models.Validations.InsuranceTitle;
using Domain.Models.Validations.User;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Globals.DataServices
{
    public interface IUserService : IService<long,
                                             Models.Entities.User,
                                             AddUserRequest, 
                                             EditUserRequest, 
                                             DeleteUserRequest,
                                             GetUserRequest,
                                             GetUsersRequest,
                                             UserResponse>
    {
        Task<bool> isUniquePhoneNumberAsync(UniquePhoneNumber request);
        Task<bool> isUniqueUserAsync(UniqueUserValidationRequst request);
        Task<bool> isUniqueEmailAsync(UniqueEmailValodationRequest request);
        Task<SigninResponse> SignInAsync(LoginRequst request);
        Task<List<IdentityResult>> AddUserToRole(AddUserToRoleRequest request);
        Task<IList<string>> GetUserRolesAsync(GetUserRequest request);
        Task SignoutAsync();
        Task<string> PhoneNumberConfirmation(string PhoneNumber);
        Task<IdentityResult> VerifyPhoneNumber(string PhoneNumber, string Token);

    }
}
