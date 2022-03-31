using FluentValidation;

namespace Domain.Models.Validations.Person
{
    public class PersonValidation : Fundamentals.Validation<long, Models.Entities.Person>
    {
        public PersonValidation()
        {
            PersonLanguageDataValidation languageValidation = new();
            RuleFor(p => p.UserId).NotNull();
            RuleFor(p => p.Name).NotNull();
            RuleFor(p => p.Family).NotNull();
            RuleFor(p => p.Gender).Must(ValidateGender);
            RuleForEach(p => p.PersonLanguageDatas).SetValidator(languageValidation);
        }
        private bool ValidateGender(byte Gender)
        {
            var result = Helpers.Globals.Enumerated.Find(typeof(Enums.Person.Gender), Gender);
            return result != "" ? true : false;
        }
    }
}
