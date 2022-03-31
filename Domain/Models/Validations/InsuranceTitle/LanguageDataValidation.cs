using FluentValidation;

namespace Domain.Models.Validations.InsuranceTitle
{
    public class InsuranceTitleLanguageDataValidation : Fundamentals.Validation<long, Entities.InsuranceTitleLanguageData>
    {
        public InsuranceTitleLanguageDataValidation()
        {
            RuleFor(p => p.LanguageId).NotNull();
            RuleFor(p=> p.Name).NotNull();
            RuleFor(p=> p.Description).NotNull();
            RuleFor(p=> p.KeyId).NotNull();
        }
    }
}
