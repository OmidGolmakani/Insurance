using Domain.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Domain.Data.DbContext
{
    public class UserStores : UserStore<User,
                                        Role,
                                        AppDbContext, 
                                        long, 
                                        UserClaim,
                                        UserRole, 
                                        UserLogin, 
                                        UserToken, 
                                        RoleClaim>
    {
        public UserStores(AppDbContext context, IdentityErrorDescriber describer = null) : base(context, describer)
        {
        }
    }
}
