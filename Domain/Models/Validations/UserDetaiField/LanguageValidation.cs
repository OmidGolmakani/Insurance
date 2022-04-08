using FluentValidation;

namespace Domain.Models.Validations.UserDetailField
{
    public class UserDetailFieldValidation : Fundamentals.Validation<long, Models.Entities.UserDetailField>
    {
        public UserDetailFieldValidation()
        {
            UserDetailFieldLanguageDataValidation languageValidation = new();
            RuleFor(p => p.Active).NotNull();
            RuleFor(p => p.Name).NotNull();
            RuleFor(p => p.DisplayName).NotNull();
            RuleFor(p => p.IsDefault).NotNull();
            RuleFor(p => p.Order).NotNull();
            RuleFor(p => p.TypeId).NotNull().Must(ValidateType);
            RuleForEach(p => p.UserDetailFieldLanguageDatas).SetValidator(languageValidation);

        }
        private bool ValidateType(byte DataType)
        {
           return  Helpers.Globals.Enumerated.EnumValidator(typeof(Enums.UserDetailField.DataType), DataType);
        }
    }
}
