using FluentValidation;

namespace Domain.Models.Validations.UserDetailField
{
    public class UserDetailFieldLanguageDataValidation : Fundamentals.Validation<long, Entities.UserDetailFieldLanguageData>
    {
        public UserDetailFieldLanguageDataValidation()
        {
            RuleFor(p => p.LanguageId).NotNull();
            RuleFor(p=> p.Name).NotNull();
            RuleFor(p => p.DisplayName).NotNull();
            RuleFor(p=> p.KeyId).NotNull();
        }
    }
}
