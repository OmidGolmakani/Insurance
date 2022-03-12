using Domain.Models.Dtos.Fundamentals.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Dtos.Requests.InsuranceTitles
{
    public class GetInsuranceTitles : GetsRequest
    {
        public decimal? Code { get; set; }
        public int? ParentId { get; set; }
        public byte? level { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? Active { get; set; }
    }
}
