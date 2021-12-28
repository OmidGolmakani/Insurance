using Domain.Interfaces.Fundamentals.Repository;
using Domain.Repositories.Fundamentals;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions.DependencyRegistration
{
    internal static class Repositores
    {
        internal static IServiceCollection AddRepositores(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));
            return services;
        }
    }
}
