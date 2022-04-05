using Domain.Interfaces.Globals.Repositories;
using Domain.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions.DependencyRegistration.Repositories
{
    public static class CompanyRepositories
    {
        public static IServiceCollection AddCompanyRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICompanyRepository, Domain.Repositories.CompanyRepository>();
            return services;
        }
        public static IServiceCollection AddCompanyLanguageDataRepositores(this IServiceCollection services)
        {
            services.AddScoped<ICompanyLanguageDataRepository, Domain.Repositories.CompanyLanguageDataRepository>();
            return services;
        }
    }
}
