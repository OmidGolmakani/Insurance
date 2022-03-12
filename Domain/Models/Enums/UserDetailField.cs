using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Enums
{
    public class UserDetailField
    {
        public enum DataType : byte
        {
           [Display(Name ="رشته-تک سطری")]
            StringSingleLine = 1,
            [Display(Name = "رشته-چند سطری")]
            StringMultiLine = 2,
            [Display(Name = "عدد صحیح")]
            Number = 3,
            [Display(Name = "عدد اعشاری")]
            Decimal = 4,
            [Display(Name = "درست یا غلط")]
            Boolean = 5,
            [Display(Name = "تاریخ")]
            DateTime = 6,
            [Display(Name = "کشویی")]
            Lockup = 7
        }
    }
}
