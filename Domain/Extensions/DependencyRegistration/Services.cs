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
                   //options.UseSqlServer(configuration["Data:DefaultConnectionString"],
                   //    options => options.MigrationsAssembly(typeof(Startup).Assembly.FullName));
                   options.UseSqlServer(configuration["Data:SecondConnectionString"],
                       options => options.MigrationsAssembly(Startup.Assembly.FullName));
               });
            services.AddScoped<Func<AppDbContext>>((provider) => () => provider.GetService<AppDbContext>());
            services.AddScoped<DbFactory>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
