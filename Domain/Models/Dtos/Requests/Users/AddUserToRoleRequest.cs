using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Dtos.Requests.Users
{
    public class AddUserToRoleRequest : Fundamentals.Requests.DeleteRequest<long>
    {
        [Required]
        public List<string> Roles { get; set; }
    }
}

