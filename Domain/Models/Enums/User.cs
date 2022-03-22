using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Enums
{
    public class User
    {
        public enum PersonType : byte
        {
            [Display(Name ="حقیقی")]
            Person = 1,
            [Display(Name = "حقوقی")]
            Company = 2
        }
    }
}
