using Domain.Models.Dtos.Fundamentals.Requests;

namespace Domain.Models.Dtos.Requests.Users
{
    public class UniquePhoneNumber : BaseRequest
    {
        public string PhoneNumber { get; set; }
    }
}
