using Domain.Models.AttributeValidations;
using Domain.Models.Dtos.Fundamentals.Requests;
using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Dtos.Requests.Companies
{
    public class GetCompaniesRequest : GetsRequest
    {
        [Required]
        [Numeric]
        public long UserId { get; set; }
        public string Name { get; set; }
        public string RegisterCode { get; set; }
        public DateTime? RegisterDate { get; set; }
    }
}
