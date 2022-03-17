using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Enums
{
    public class Person
    {
        public enum Gender : byte
        {
           [Display(Name ="مرد")]
            Male = 1,
            [Display(Name = "زن")]
            Female = 2
        }
    }
}
