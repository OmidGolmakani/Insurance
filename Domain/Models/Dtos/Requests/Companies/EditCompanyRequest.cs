using Domain.Interfaces.Fundamentals.Request;
using Domain.Models.Dtos.Fundamentals.Requests;
using Domain.Models.Dtos.Requests.CompanyLanguageDatas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Dtos.Requests.Companies
{
    public class EditCompanyRequest : EditRequest<long>, IListDataLanguageRequest<long, EditCompanyLanguageDataRequest>
    {
        [Required]
        public long UserId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string RegisterCode { get; set; }
        [Required]
        public DateTime RegisterDate { get; set; }
        public List<EditCompanyLanguageDataRequest> LanguageDatas { get; set; } = new();
    }
}
