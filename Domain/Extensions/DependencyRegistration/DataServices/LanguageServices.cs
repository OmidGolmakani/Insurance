using Domain.Interfaces.Globals.DataServices;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions.DependencyRegistration.DataServices
{
    public static class LanguageServices
    {
        public static IServiceCollection AddLanguageServices(this IServiceCollection services)
        {
            services.AddScoped<ILanguageService, Services.Data.Global.LanguageService>();
            return services;
        }
    }
}
