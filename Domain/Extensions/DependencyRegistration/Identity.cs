using Domain.Data.DbContext;
using Domain.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions.DependencyRegistration
{
    public static class Identity
    {
        public static IServiceCollection MyIdentity(this IServiceCollection services)
        {
            services.AddIdentity<User, Role>(config =>
            {
                config.Password.RequireDigit = false;
                //config.Password.RequiredLength = 10;
                config.Password.RequireLowercase = false;
                config.Password.RequireUppercase = false;
                config.Password.RequireNonAlphanumeric = false;
                config.User.RequireUniqueEmail = false;
                config.SignIn.RequireConfirmedEmail = false;
                config.SignIn.RequireConfirmedPhoneNumber = true;
            })
            .AddEntityFrameworkStores<AppDbContext>()
            .AddUserStore<UserStores>()
            .AddRoles<Role>()
            .AddDefaultTokenProviders();
            return services;
        }
    }
}
