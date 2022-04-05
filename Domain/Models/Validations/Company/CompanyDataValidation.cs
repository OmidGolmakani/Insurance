using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Validations.Company
{
    public class CompanyLanguageDataValidation : Fundamentals.Validation<long, Models.Entities.CompanyLanguageData>
    {
        public CompanyLanguageDataValidation()
        {
            RuleFor(p => p.LanguageId).NotNull();
            RuleFor(p => p.Name).NotNull();
            RuleFor(p => p.RegisterCode).NotNull();
            RuleFor(p => p.KeyId).NotNull();
        }
    }
}
