using FluentValidation;

namespace Domain.Models.Validations.Language
{
    public class LanguageValidation : Fundamentals.Validation<int, Models.Entities.Language>
    {
        public LanguageValidation()
        {
            RuleFor(p => p.LanguageName).NotNull();
            RuleFor(p => p.AcceptLanguage).NotNull();
            RuleFor(p => p.Direction).NotNull().Must(ValidateDirection);

        }
        private bool ValidateDirection(byte Direction)
        {
            var en = Helpers.Globals.Enumerated.Find(typeof(Enums.Language.Direction), Direction);
            return en != "" ? true : false;
        }
    }
}
