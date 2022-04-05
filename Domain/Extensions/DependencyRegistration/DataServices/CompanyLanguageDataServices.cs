using Domain.Interfaces.Globals.DataServices;
using Domain.Services.Data.Global;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions.DependencyRegistration.DataServices
{
    public static class CompanyLanguageDataServices
    {
        public static IServiceCollection AddCompanyServices(this IServiceCollection services)
        {
            services.AddScoped<ICompanyService, CompanyService>();
            return services;
        }
        public static IServiceCollection AddCompanyLanguageDataServices(this IServiceCollection services)
        {
            services.AddScoped<ICompanyLanguageDataService, CompanyLanguageDataService>();
            return services;
        }
    }
}
