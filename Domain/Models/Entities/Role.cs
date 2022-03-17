using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Domain.Models.Entities
{
    public class Role : IdentityRole<long>
    {
        public Role()
        {
        }
        public string DisplayName { get; set; }
        public ICollection<RolePermission> RolePermissions { get; set; }
    }
}
