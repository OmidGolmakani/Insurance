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
            #region Insurance Title
            services.AddInsuranceTitleServices();
            services.AddInsuranceTitleLanguageDataServices();
            #endregion Insurance Title
            #region User
            services.AddUserServices();
            #endregion User
            #region Language
            services.AddLanguageServices();
            #endregion Language
            #region Person
            services.AddPersonLanguageDataServices();
            services.AddPersonServices();
            #endregion Person
            #region Company
            services.AddCompanyLanguageDataServices();
            services.AddCompanyServices();
            #endregion Company

            return services;
        }
    }
}
