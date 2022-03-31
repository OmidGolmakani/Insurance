using Domain.Models.Entities;
using Domain.Models.Validations.InsuranceTitle;
using Domain.Models.Validations.Language;
using Domain.Models.Validations.Person;
using Domain.Models.Validations.User;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions.DependencyRegistration
{
    public static class Validations
    {
        public static IServiceCollection AddValidations(this IServiceCollection services)
        {
            services.AddScoped<FluentValidation.IValidator<InsuranceTitleLanguageData>, InsuranceTitleLanguageDataValidation>();
            services.AddScoped<FluentValidation.IValidator<InsuranceTitle>, InsuranceTitleValidation>();
            services.AddScoped<FluentValidation.IValidator<User>, UserValidation>();
            services.AddScoped<FluentValidation.IValidator<Language>, LanguageValidation>();
            services.AddScoped<FluentValidation.IValidator<PersonLanguageData>, PersonLanguageDataValidation>();
            services.AddScoped<FluentValidation.IValidator<Person>, PersonValidation>();

            return services;
        }
    }
}
