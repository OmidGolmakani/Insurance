using Domain.Models.Dtos.Fundamentals.Requests;

namespace Domain.Models.Dtos.Requests.Users
{
    public class UniqueUserValidationRequst : BaseRequest
    {
        public string UserName { get; set; }
    }
}
