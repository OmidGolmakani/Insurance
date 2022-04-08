using Domain.Interfaces.Globals.Repositories;
using Domain.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions.DependencyRegistration.Repositories
{
    public static class UserDetailFieldRepositories
    {
        public static IServiceCollection AddUserDetailFieldRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserDetailFieldRepository, Domain.Repositories.UserDetailFieldRepository>();
            return services;
        }
        public static IServiceCollection AddUserDetailFieldLanguageDataRepositores(this IServiceCollection services)
        {
            services.AddScoped<IUserDetailFieldLanguageDataRepository, UserDetailFieldLanguageDataRepository>();
            return services;
        }
    }
}
