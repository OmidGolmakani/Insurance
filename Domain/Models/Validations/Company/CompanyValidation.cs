using Domain.Models.Validations.Person;
using FluentValidation;

namespace Domain.Models.Validations.Company
{
    public class CompanyValidation : Fundamentals.Validation<long, Models.Entities.Company>
    {
        public CompanyValidation()
        {
            CompanyLanguageDataValidation languageValidation = new();
          
            RuleForEach(p => p.CompanyLanguageDatas).SetValidator(languageValidation);
        }
    }
}
