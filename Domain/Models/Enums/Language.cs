using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Enums
{
    public class Language
    {
        public enum Direction : byte
        {
            [Display(Name = "چب به راست")]
            LeftToRight = 1,
            [Display(Name = "راست به چپ")]
            RightToLeft = 2,
        }
        public enum Lanuage : byte
        {
            [Display(Name = "fa-IR")]
            Persian = 1,
            [Display(Name = "en-US")]
            English = 2

        }
    }
}
