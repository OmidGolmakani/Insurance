using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data.Seeding
{
    public class UserRoles
    {
        public List<Models.Entities.UserRole> GetSeeding()
        {
            return new List<Models.Entities.UserRole>()
            {
               new Models.Entities.UserRole()
               {
                   RoleId=1,
                   UserId=1
               }
            };
        }
    }
}
