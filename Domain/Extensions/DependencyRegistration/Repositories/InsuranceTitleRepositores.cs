using Domain.Interfaces.Globals.Repositories;
using Domain.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions.DependencyRegistration.Repositories
{
    public static class InsuranceTitleRepositories
    {
        public static IServiceCollection AddInsuranceTitleRepositoryRepositories(this IServiceCollection services)
        {
            services.AddScoped<IInsuranceTitleRepository, Domain.Repositories.InsuranceTitleRepository>();
            return services;
        }
    }
}
