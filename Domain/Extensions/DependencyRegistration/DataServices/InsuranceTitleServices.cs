using Domain.Interfaces.Globals.DataServices;
using Domain.Services.Data.Global;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions.DependencyRegistration.DataServices
{
    public static class InsuranceTitleServices
    {
        public static IServiceCollection AddInsuranceTitleServices(this IServiceCollection services)
        {
            services.AddScoped<IInsuranceTitleService, InsuaranceTitleService>();
            return services;
        }
    }
}
