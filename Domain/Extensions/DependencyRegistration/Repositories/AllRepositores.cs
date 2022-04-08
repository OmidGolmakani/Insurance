using Domain.Extensions.DependencyRegistration.Repositories;
using Domain.Interfaces.Fundamentals.Repository;
using Domain.Repositories.Fundamentals;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions.DependencyRegistration
{
    public static class AllRepositories
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<,,,,>), typeof(Repository<,,,,>));
            #region User
            services.AddUserRepositories(); 
            #endregion User
            #region Insurance Title
            services.AddInsuranceTitleRepositories();
            services.AddInsuranceTitleLanguageDataRepositores();
            #endregion Insurance Title
            #region Language
            services.AddLanguageRepositories();
            #endregion Language
            #region Person
            services.AddPersonRepositores();
            services.AddPersonLanguageDataRepositores(); 
            #endregion Person
            #region Company
            services.AddCompanyRepositories();
            services.AddCompanyLanguageDataRepositores();
            #endregion Company
            #region User Detail Field
            services.AddUserDetailFieldRepositories();
            services.AddUserDetailFieldLanguageDataRepositores();
            #endregion User Detail Field
            return services;
        }
    }
}
