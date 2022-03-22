using Domain.Models.Dtos.Fundamentals.Response;

namespace Domain.Models.Dtos.Responses.Users
{
    public class UserResponse : BaseResponse<long>
    {
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string NationalId { get; set; }
        public string ReasonDeactivation { get; set; }
        public string Image { get; set; }
    }
}
