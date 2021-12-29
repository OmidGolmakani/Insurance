using Domain.Models.Dtos.Fundamentals.Response;
using Microsoft.AspNetCore.Identity;

namespace Domain.Models.Dtos.Responses.Users
{
    public class SigninResponse : BaseResponse<long>
    {
        public SignInResult SignIn { get; set; }
        public TokenResponse Token { get; set; }
        public bool IsAdmin { get; set; }
    }
}
