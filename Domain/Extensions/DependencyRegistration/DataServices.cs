using Domain.Interfaces.Fundamentals.DataService;
using Domain.Interfaces.Globals.DataServices;
using Domain.Services.Data.Fundamentals;
using Domain.Services.Data.Global;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions.DependencyRegistration
{
    public static class DataServices
    {
        /// <summary>
        /// Registration of data services
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddDataServises(this IServiceCollection services)
        {
            services.AddScoped(typeof(IService<,,,,,,,>), typeof(Service<,,,,,,,>));
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IInsuranceTitleService, InsuaranceTitleService>();

            return services;
        }
    }
}
