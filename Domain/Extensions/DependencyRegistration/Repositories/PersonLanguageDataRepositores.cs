using Domain.Interfaces.Globals.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions.DependencyRegistration.Repositories
{
    public static class PersonLanguageDataRepositores
    {
        public static IServiceCollection AddPersonLanguageDataRepositores(this IServiceCollection services)
        {
            services.AddScoped<IPersonLanguageDataRepository, Domain.Repositories.PersonLanguageDataRepository>();
            return services;
        }
    }
}
