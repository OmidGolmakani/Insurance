using Domain.Interfaces.Globals.DataServices;
using Domain.Models.Validations.Fundamentals;
using FluentValidation;

namespace Domain.Models.Validations.InsuranceTitle
{
    public class InsuranceTitleValidation : Validation<int, Models.Entities.InsuranceTitle>
    {

        public InsuranceTitleValidation(IInsuranceTitleService insuranceTitleService)
        {
            RuleFor(p => p.Name).NotNull();
        }
    }
}
