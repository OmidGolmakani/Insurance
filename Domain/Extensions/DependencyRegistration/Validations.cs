using Domain.Models.Entities;
using Domain.Models.Validations.Company;
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
            #region Insurance Title
            services.AddScoped<FluentValidation.IValidator<InsuranceTitleLanguageData>, InsuranceTitleLanguageDataValidation>();
            services.AddScoped<FluentValidation.IValidator<InsuranceTitle>, InsuranceTitleValidation>();
            #endregion Insurance Title
            #region User
            services.AddScoped<FluentValidation.IValidator<User>, UserValidation>();
            #endregion User
            #region Language
            services.AddScoped<FluentValidation.IValidator<Language>, LanguageValidation>();
            #endregion Language
            #region Person
            services.AddScoped<FluentValidation.IValidator<PersonLanguageData>, PersonLanguageDataValidation>();
            services.AddScoped<FluentValidation.IValidator<Person>, PersonValidation>();
            #endregion Person
            #region Person
            services.AddScoped<FluentValidation.IValidator<CompanyLanguageData>, CompanyLanguageDataValidation>();
            services.AddScoped<FluentValidation.IValidator<Company>, CompanyValidation>();
            #endregion Person

            return services;
        }
    }
}
