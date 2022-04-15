using Domain.Extensions.DependencyRegistration.Repositories;
using Domain.Helpers.ConstVariables;
using Domain.Interfaces.Fundamentals.Repository;
using Domain.Repositories.Fundamentals;
using Microsoft.Extensions.DependencyInjection;
using static Domain.Helpers.Globals.ReflectionHelper.Enums;

namespace Domain.Extensions.DependencyRegistration
{
    public static class AllRepositories
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<,,,,>), typeof(Repository<,,,,>));
            Helpers.Globals.ReflectionHelper reflectionHelper = new();
            reflectionHelper.Register(NameSpaces.Repositories,services,registerType.Scope);
            #region User
            services.AddUserRepositories();
            #endregion User
            return services;
        }
    }
}
