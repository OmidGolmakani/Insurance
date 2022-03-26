using Domain.Interfaces.Fundamentals.Request;

namespace Domain.Models.Dtos.Requests.Users
{
    public class GetUsersRequest : Fundamentals.Requests.GetsRequest
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string PhoneNUmber { get; set; }
        public string Email { get; set; }
    }
}
