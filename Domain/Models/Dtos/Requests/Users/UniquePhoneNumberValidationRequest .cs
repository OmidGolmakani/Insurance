using Domain.Models.Dtos.Fundamentals.Requests;

namespace Domain.Models.Dtos.Requests.Users
{
    public class UniquePhoneNumber : BaseRequest
    {
        public long Id { get; set; }
        public string PhoneNumber { get; set; }
    }
}
