using System.Collections.Generic;

namespace Domain.Models.Dtos.Requests.Users
{
    public class AddUserToRoleRequest : Fundamentals.Requests.DeleteRequest<long>
    {
        public List<string> Roles { get; set; }
    }
}

