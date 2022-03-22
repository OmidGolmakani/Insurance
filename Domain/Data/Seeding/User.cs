using Domain.Interfaces.Fundamentals.DataSeeding;
using System.Collections.Generic;

namespace Domain.Data.Seeding
{
    public class User
    {
        public List<Models.Entities.User> GetSeeding()
        {
            return new List<Models.Entities.User>()
            {
                new Models.Entities.User()
                {
                    Id = 1,
                    UserName = Helpers.ConstVariables.Globals.AdminUserName,
                    Block=false,
                    ParentId=null,
                    CreatedBy=Helpers.ConstVariables.Globals.SystemUserName,
                    CreatedDate =System.DateTime.Now,
                    HasImage=false,
                    IsDeleted=false,
                    LanguageId=(byte)Models.Enums.Language.Lanuage.Persian,
                    NationalId = null,
                    NormalizedUserName = Helpers.ConstVariables.Globals.AdminUserName.ToUpper(),
                    PasswordHash = "AQAAAAEAACcQAAAAEKW/y44Jh9PvnN76n0szdq7UROQdDzJ00uYmnm/9IIT/sj1wwIp+9xGys5WvqlIQhg==",
                    PhoneNumber ="09111111111",
                    PhoneNumberConfirmed=true,
                    PersonType = (byte)Models.Enums.User.PersonType.Person,
                    SecurityStamp ="TJUF2RGBNANVU2SAL3V5N6AL76XVC445",
                    ConcurrencyStamp ="69e99f0a-aae2-456a-a3d7-360ddbcf85c0"

                }
            };
        }
    }
}
