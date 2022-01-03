using Domain.Models.Dtos.Fundamentals.Requests;

namespace Domain.Models.Dtos.Requests.Users
{
    public class VerifyEmail : BaseRequest
    {
        public long UserId { get; set; }
        public string VerificationCode { get; set; }
    }
}
