using Domain.Models.Dtos.Fundamentals.Request;

namespace Domain.Models.Dtos.Requests.Users
{
    public class AddUserRequest : AddRequest
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
