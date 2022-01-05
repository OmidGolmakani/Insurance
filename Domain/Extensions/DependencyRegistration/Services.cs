using Domain.Data.DbContext;
using Domain.Interfaces.Fundamentals.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Domain.Extensions.DependencyRegistration
{
    public static class Services
    {
        public static IServiceCollection AddServises(this IServiceCollection services, IConfiguration configuration,Type Startup)
        {
            services.AddEntityFrameworkSqlServer()
               .AddDbContext<AppDbContext>(options =>
               {
                   options.UseSqlServer(configuration["Data:ConnectionString"]);
               });
            services.AddScoped<Func<AppDbContext>>((provider) => () => provider.GetService<AppDbContext>());
            services.AddScoped<DbFactory>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
