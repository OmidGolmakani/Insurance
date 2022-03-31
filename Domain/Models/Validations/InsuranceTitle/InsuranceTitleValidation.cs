using FluentValidation;

namespace Domain.Models.Validations.InsuranceTitle
{
    public class InsuranceTitleValidation : Fundamentals.Validation<int, Models.Entities.InsuranceTitle>
    {
        public InsuranceTitleValidation()
        {
            InsuranceTitleLanguageDataValidation languageValidation = new();
            RuleFor(p => p.Name).NotNull();
            RuleFor(p => p.Description).NotNull();
            RuleForEach(p => p.InsuranceTitleLanguageDatas).SetValidator(languageValidation);
        }
    }
}
