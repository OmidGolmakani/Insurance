using Domain.Models.Dtos.Fundamentals.Requests;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Dtos.Requests.Users
{
    public class UniqueUserValidationRequst : BaseRequest
    {
        public long Id { get; set; }
        [Required]
        public string UserName { get; set; }
    }
}
