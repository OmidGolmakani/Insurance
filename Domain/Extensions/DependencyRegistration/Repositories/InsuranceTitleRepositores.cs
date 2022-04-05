﻿using Domain.Interfaces.Globals.Repositories;
using Domain.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions.DependencyRegistration.Repositories
{
    public static class InsuranceTitleRepositories
    {
        public static IServiceCollection AddInsuranceTitleRepositories(this IServiceCollection services)
        {
            services.AddScoped<IInsuranceTitleRepository, Domain.Repositories.InsuranceTitleRepository>();
            return services;
        }
        public static IServiceCollection AddInsuranceTitleLanguageDataRepositores(this IServiceCollection services)
        {
            services.AddScoped<IInsuranceTitleLanguageDataRepository, Domain.Repositories.InsuranceTitleLanguageDataRepository>();
            return services;
        }
    }
}
