using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data.Seeding
{
    public class Role
    {
        public List<Models.Entities.Role> GetSeeding()
        {
            return new List<Models.Entities.Role>()
            {
                new Models.Entities.Role()
                {
                    Id=1,
                    Name = Helpers.ConstVariables.Globals.AdministratorRoleName,
                    NormalizedName = Helpers.ConstVariables.Globals.AdministratorRoleName.ToUpper(),
                    DisplayName = Helpers.ConstVariables.Globals.AdministratorRoleDisplayName,
                    ConcurrencyStamp ="420d99de-7b2d-4a31-acd9-da52b0927bd0"
                },
                 new Models.Entities.Role()
                {
                    Id=2,
                    Name = Helpers.ConstVariables.Globals.GuestRoleName,
                    NormalizedName = Helpers.ConstVariables.Globals.GuestRoleName.ToUpper(),
                    DisplayName = Helpers.ConstVariables.Globals.GuestRoleDisplayName,
                    ConcurrencyStamp ="b212d236-c010-41bf-958a-71d77a3d61c2"
                }
            };
        }
    }
}
