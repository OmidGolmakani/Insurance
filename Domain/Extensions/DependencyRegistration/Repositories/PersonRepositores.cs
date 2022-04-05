using Domain.Interfaces.Globals.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions.DependencyRegistration.Repositories
{
    public static class PersonRepositores
    {
        public static IServiceCollection AddPersonRepositores(this IServiceCollection services)
        {
            services.AddScoped<IPersonRepository, Domain.Repositories.PersonRepository>();
            return services;
        }
        public static IServiceCollection AddPersonLanguageDataRepositores(this IServiceCollection services)
        {
            services.AddScoped<IPersonLanguageDataRepository, Domain.Repositories.PersonLanguageDataRepository>();
            return services;
        }
    }
}
