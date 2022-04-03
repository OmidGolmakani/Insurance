using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Enums
{
    public class Order
    {
        public enum OrderType : byte
        {
            [Display(Name ="ندارد")]
            None = 0,
            [Display(Name ="صعودی")]
            Ascending = 1,
            [Display(Name = "نزولی")]
            Descending = 2,
        }
    }
}
