using Domain.Extensions.Other;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain.Attributes
{
    public class NumericAttribute : RegularExpressionAttribute
    {
        public NumericAttribute(string pattern) : base(pattern)
        {

        }
        public NumericAttribute() : base("(.*[1-9].*)|(.*[.].*[1-9].*)")
        {
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var isMatch = Regex.IsMatch(value.ToString(), "(.*[1-9].*)|(.*[.].*[1-9].*)");
            var result = base.IsValid(value, validationContext);
            if (isMatch == false)
            {
                return new ValidationResult($"This field must have a numeric value greater than zero", result.MemberNames);
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}
