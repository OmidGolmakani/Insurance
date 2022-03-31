using Domain.Interfaces.Globals.DataServices;
using Domain.Services.Data.Global;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions.DependencyRegistration.DataServices
{
    public static class PersonLanguageDataServices
    {
        public static IServiceCollection AddPersonLanguageDataServices(this IServiceCollection services)
        {
            services.AddScoped<IPersonLanguageDataService, PersonLanguageDataService>();
            return services;
        }
    }
}
