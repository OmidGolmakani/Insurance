using Domain.Models.Dtos.Fundamentals.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Dtos.Responses.RolePermissions
{
    public class RolePermissionResponse : BaseResponse<long>
    {
        public string RoleId { get; set; }
        public string Url { get; set; }
        public string Token { get; set; }
        public Roles.RoleResponse Role { get; set; }
    }
}
