using Domain.Extensions.DependencyRegistration.DataServices;
using Domain.Helpers.ConstVariables;
using Domain.Interfaces.Fundamentals.DataService;
using Domain.Services.Data.Fundamentals;
using Microsoft.Extensions.DependencyInjection;
using static Domain.Helpers.Globals.ReflectionHelper.Enums;

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
            Helpers.Globals.ReflectionHelper reflectionHelper = new();
            reflectionHelper.Register(NameSpaces.DataServices, services, registerType.Scope);
            #region User
            services.AddUserServices();
            #endregion User
            return services;
        }
    }
}
