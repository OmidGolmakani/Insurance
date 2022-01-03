using Domain.Models.Dtos.Fundamentals.Requests;

namespace Domain.Models.Dtos.Requests.Users
{
    public class UniqueEmailValodationRequest : BaseRequest
    {
        public string Email { get; set; }
    }
}
