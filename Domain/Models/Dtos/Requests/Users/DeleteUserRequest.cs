using Domain.Models.Dtos.Fundamentals.Requests;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Dtos.Requests.Users
{
    public class DeleteUserRequest : DeleteRequest<long>
    {
        [Required]
        public string ReasonDeactivation { get; set; }
    }
}
