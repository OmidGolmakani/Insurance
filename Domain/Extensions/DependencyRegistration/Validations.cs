using Domain.Models.Entities;
using Domain.Models.Validations.InsuranceTitle;
using Domain.Models.Validations.Language;
using Domain.Models.Validations.User;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions.DependencyRegistration
{
    public static class Validations
    {
        public static IServiceCollection AddValidations(this IServiceCollection services)
        {
            services.AddScoped<FluentValidation.IValidator<InsuranceTitleLanguageData>, LanguageDataValidation>();
            services.AddScoped<FluentValidation.IValidator<InsuranceTitle>, InsuranceTitleValidation>();
            services.AddScoped<FluentValidation.IValidator<User>, UserValidation>();
            services.AddScoped<FluentValidation.IValidator<Language>, LanguageValidation>();

            return services;
        }
    }
}
