using Domain.Interfaces.Globals.DataServices;
using Domain.Services.Data.Global;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions.DependencyRegistration.DataServices
{
    public static class InsuranceTitleLanguageDataServices
    {
        public static IServiceCollection AddInsuranceTitleLanguageDataServices(this IServiceCollection services)
        {
            services.AddScoped<IInsuranceTitleLanguageDataService, InsuaranceTitleLanguageDataService>();
            return services;
        }
    }
}
