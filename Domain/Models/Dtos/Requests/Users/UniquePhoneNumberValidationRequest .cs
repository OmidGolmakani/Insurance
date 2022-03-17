using Domain.Models.Dtos.Fundamentals.Requests;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Dtos.Requests.Users
{
    public class UniquePhoneNumber : BaseRequest
    {
        public long Id { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
    }
}
