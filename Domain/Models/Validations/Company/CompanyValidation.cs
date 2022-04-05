using Domain.Models.Validations.Person;
using FluentValidation;

namespace Domain.Models.Validations.Company
{
    public class CompanyValidation : Fundamentals.Validation<long, Models.Entities.Company>
    {
        public CompanyValidation()
        {
            CompanyLanguageDataValidation languageValidation = new();
            RuleFor(p => p.UserId).NotNull();
            RuleFor(p => p.Name).NotNull();
            RuleFor(p => p.RegisterCode).NotNull();
            RuleFor(p=> p.RegisterDate).NotNull();
            RuleForEach(p => p.CompanyLanguageDatas).SetValidator(languageValidation);
        }
    }
}
