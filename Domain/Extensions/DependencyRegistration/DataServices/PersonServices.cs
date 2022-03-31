using Domain.Interfaces.Globals.DataServices;
using Domain.Services.Data.Global;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions.DependencyRegistration.DataServices
{
    public static class PersonServices
    {
        public static IServiceCollection AddPersonServices(this IServiceCollection services)
        {
            services.AddScoped<IPersonService, PersonService>();
            return services;
        }
    }
}
