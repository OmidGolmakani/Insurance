using Domain.Models.Entities;
using Domain.Models.Validations.InsuranceTitle;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions.DependencyRegistration
{
    public static class Validations
    {
        public static IServiceCollection AddValidations(this IServiceCollection services)
        {
            services.AddScoped<FluentValidation.IValidator<InsuranceTitle>, InsuranceTitleValidation>();

            return services;
        }
    }
}
