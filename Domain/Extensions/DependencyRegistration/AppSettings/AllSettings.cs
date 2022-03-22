using Domain.Extensions.DependencyRegistration.AppSettings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions.DependencyRegistration
{
    public static class AllSettings
    {
        public static IServiceCollection BindSettings(this IServiceCollection services,IConfiguration configuration)
        {
            services.BindAuthenticationSettings(configuration);
            return services;
        }
    }
}
