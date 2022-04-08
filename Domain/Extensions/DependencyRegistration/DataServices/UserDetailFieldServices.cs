using Domain.Interfaces.Globals.DataServices;
using Domain.Services.Data.Global;
using Microsoft.Extensions.DependencyInjection;
namespace Domain.Extensions.DependencyRegistration.DataServices
{
    public static class UserDetailFieldServices
    {
        public static IServiceCollection AddUserDetailFieldServices(this IServiceCollection services)
        {
            services.AddScoped<IUserDetailFieldService, UserDetailFieldService>();
            return services;
        }
        public static IServiceCollection AddUserDetailFieldLanguageDataServices(this IServiceCollection services)
        {
            services.AddScoped<IUserDetailFieldLanguageDataService, UserDetailFieldLanguageDataService>();
            return services;
        }
    }
}
