using Domain.Filters;
using Domain.Models.Dtos.Fundamentals.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Dtos.Requests.InsuranceTitles
{
    public class AddInsuranceTitleRequest : AddRequest
    {
        public decimal? Code { get; set; }
        public int? ParentId { get; set; }
        [Required]
        public byte level { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [DefaultValue(true)]
        [Required]
        public bool Active { get; set; } = true;
    }
}
