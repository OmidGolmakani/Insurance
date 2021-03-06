using Domain.Data.DbContext;
using Domain.Interfaces.Fundamentals.Repository;
using Domain.Interfaces.Globals.DataServices;
using Domain.Services.Data.Global;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Domain.Extensions.DependencyRegistration
{
    public static class GlobalServices
    {
        /// <summary>
        /// Registration of public services
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <param name="Startup"></param>
        /// <returns></returns>
        public static IServiceCollection AddGlobalServises(this IServiceCollection services, IConfiguration configuration,Type Startup)
        {
            services.AddEntityFrameworkSqlServer()
               .AddDbContext<AppDbContext>(options =>
               {
                   options.UseSqlServer(configuration["Data:ConnectionString"]);
               });
            services.AddScoped<SqlConnection>(db => new SqlConnection(
                    configuration["Data:ConnectionString"]));
            services.AddScoped<Func<AppDbContext>>((provider) => () => provider.GetService<AppDbContext>());
            services.AddScoped<Func<SqlConnection>>((provider) => () => provider.GetService<SqlConnection>());
            services.AddScoped<DbFactory>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
