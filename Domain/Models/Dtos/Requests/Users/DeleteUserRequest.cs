using Domain.Models.Dtos.Fundamentals.Request;

namespace Domain.Models.Dtos.Requests.Users
{
    public class DeleteUserRequest : DeleteRequest<long>
    {
        public string ReasonDeactivation { get; set; }
    }
}
