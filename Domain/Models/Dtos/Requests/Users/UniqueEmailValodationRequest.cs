using Domain.Models.Dtos.Fundamentals.Requests;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Dtos.Requests.Users
{
    public class UniqueEmailValodationRequest : BaseRequest
    {
        public long Id { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
