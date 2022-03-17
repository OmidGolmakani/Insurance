using Domain.Models.Dtos.Fundamentals.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Dtos.Requests.InsuranceTitles
{
    public class EditInsuranceTitleRequest : EditRequest<int>
    {
        public decimal? Code { get; set; }
        public int? ParentId { get; set; }
        [Required]
        public byte level { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public bool Active { get; set; }
    }
}
