using Domain.Interfaces.Fundamentals.Repository;
using Domain.Models.Dtos.Requests.Users;
using Domain.Models.Dtos.Responses.Users;
using Domain.Models.Entities;
using System.Threading.Tasks;

namespace Domain.Interfaces.Globals.Repositories
{
    public interface IUserRepository : IRepository<long, User, GetUserRequest, GetUsersRequest, UserResponse>
    {
        Task<bool> isUniqueEmailAsync(UniqueEmailValodationRequest request);
        Task<bool> isUniquePhoneNumberAsync(UniquePhoneNumber request);
        Task<bool> isUniqueUserAsync(UniqueUserValidationRequst request);
        Task<SigninResponse> SigninAsync(LoginRequst requst);
        Task SignoutAsync();
    }
}
