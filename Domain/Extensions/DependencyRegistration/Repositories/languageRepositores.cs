using Domain.Interfaces.Globals.Repositories;
using Domain.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions.DependencyRegistration.Repositories
{
    public static class LanguageRepositories
    {
        public static IServiceCollection AddLanguageRepositoryRepositories(this IServiceCollection services)
        {
            services.AddScoped<ILanguageRepository, Domain.Repositories.LanguageRepository>();
            return services;
        }
    }
}
