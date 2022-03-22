using Domain.Interfaces.Globals.DataServices;
using Domain.Services.Data.Global;
using Microsoft.Extensions.DependencyInjection;
namespace Domain.Extensions.DependencyRegistration.DataServices
{
    public static class UserServices
    {
        public static IServiceCollection AddUserServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, Services.Data.Global.UserService>();
            return services;
        }
    }
}
