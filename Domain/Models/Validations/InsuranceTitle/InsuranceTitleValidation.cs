using FluentValidation;

namespace Domain.Models.Validations.InsuranceTitle
{
    public class InsuranceTitleValidation : Fundamentals.Validation<int, Models.Entities.InsuranceTitle>
    {
        public InsuranceTitleValidation()
        {
            RuleFor(p => p.Name).NotNull();
        }
    }
}
