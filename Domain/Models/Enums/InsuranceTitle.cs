using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Enums
{
    public class InsuranceTitle
    {
        public enum Level : byte
        {
            [Display(Name ="رشته بیمه")]
            Level1 = 1,
            [Display(Name = "زیر رشته بیمه")]
            Level2 = 2
        }
    }
}
