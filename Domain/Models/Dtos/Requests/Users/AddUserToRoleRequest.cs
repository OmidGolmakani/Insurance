using System.Collections.Generic;

namespace Domain.Models.Dtos.Requests.Users
{
    public class AddUserToRoleRequest : Models.Dtos.Fundamentals.Request.DeleteRequest<long>
    {
        public List<string> Roles { get; set; }
    }
}
