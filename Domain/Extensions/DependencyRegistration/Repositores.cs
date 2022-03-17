using Domain.Interfaces.Fundamentals.Repository;
using Domain.Interfaces.Globals.Repositores;
using Domain.Repositories;
using Domain.Repositories.Fundamentals;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions.DependencyRegistration
{
    public static class Repositores
    {
        public static IServiceCollection AddRepositores(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<,,,,>), typeof(Repository<,,,,>));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IInsuranceTitleRepository, InsuranceTitleRepository>();


            return services;
        }
    }
}
