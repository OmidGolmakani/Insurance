using Domain.Interfaces.Fundamentals.Request;
using Domain.Models.Dtos.Fundamentals.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Dtos.Requests.InsuranceTitles
{
    public class GetInsuranceTitlesRequest : GetsRequest
    {
        public decimal? Code { get; set; }
        public int? ParentId { get; set; }
        public byte? level { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? Active { get; set; }
        //[DefaultValue(false)]
        //[Required]
        //[NotMapped]
        //public bool GetOutherLanguageData { get; set; }
    }
}
