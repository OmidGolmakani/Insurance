using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Enums
{
    public class Point
    {
        public enum RankValue : byte
        {
            [Display(Name = "خیلی بد")]
            VeryBad,
            [Display(Name = "بد")]
            Bad,
            [Display(Name = "متوسط")]
            Normal,
            [Display(Name = "خوب")]
            Good,
            [Display(Name = "خیلی خوب")]
            VeryGood,
            [Display(Name = "عالی")]
            Perfectly
        }
    }
}
