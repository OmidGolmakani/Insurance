using FluentValidation;

namespace Domain.Models.Validations.InsuranceTitle
{
    public class LanguageDataValidation : Fundamentals.Validation<long, Models.Entities.InsuranceTitleLanguageData>
    {
        public LanguageDataValidation()
        {
            RuleFor(p => p.LanguageId).NotNull();
            RuleFor(p=> p.Name).NotNull();
            RuleFor(p=> p.Description).NotNull();
            RuleFor(p=> p.KeyId).NotNull();
        }
    }
}
