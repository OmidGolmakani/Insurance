﻿using Domain.Extensions.DependencyRegistration.Repositories;
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
            services.AddUserRepositories();
            services.AddInsuranceTitleRepositoryRepositories();

            return services;
        }
    }
}
