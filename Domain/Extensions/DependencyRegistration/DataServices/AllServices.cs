using Domain.Extensions.DependencyRegistration.DataServices;
using Domain.Interfaces.Fundamentals.DataService;
using Domain.Services.Data.Fundamentals;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions.DependencyRegistration
{
    public static partial class AllServices
    {
        /// <summary>
        /// Registration of data services
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddDataServises(this IServiceCollection services)
        {
            services.AddScoped(typeof(IService<,,,,,,,>), typeof(Service<,,,,,,,>));
            services.AddInsuranceTitleServices();
            services.AddInsuranceTitleLanguageDataServices();
            services.AddUserServices();
            services.AddLanguageServices();
            return services;
        }
    }
}
