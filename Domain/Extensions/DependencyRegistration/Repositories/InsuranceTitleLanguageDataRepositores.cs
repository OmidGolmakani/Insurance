using Domain.Interfaces.Globals.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions.DependencyRegistration.Repositories
{
    public static class InsuranceTitleLanguageDataRepositores
    {
        public static IServiceCollection AddInsuranceTitleLanguageDataRepositores(this IServiceCollection services)
        {
            services.AddScoped<IInsuranceTitleLanguageDataRepository, Domain.Repositories.InsuranceTitleLanguageDataRepository>();
            return services;
        }
    }
}
