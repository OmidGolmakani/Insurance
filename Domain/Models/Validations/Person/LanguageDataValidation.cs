using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Validations.Person
{
    public class PersonLanguageDataValidation : Fundamentals.Validation<long, Models.Entities.PersonLanguageData>
    {
        public PersonLanguageDataValidation()
        {
            RuleFor(p => p.LanguageId).NotNull();
            RuleFor(p => p.Name).NotNull();
            RuleFor(p => p.Family).NotNull();
            RuleFor(p => p.KeyId).NotNull();
        }
    }
}
