using Domain.Interfaces.Fundamentals.Request;
using Domain.Models.Dtos.Fundamentals.Requests;
using Domain.Models.Dtos.Requests.InsuranceTitleLanguageDatas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Dtos.Requests.InsuranceTitles
{
    public class AddCompanyRequest : AddRequest, IListDataLanguageRequest<long, AddCompanyLanguageDataRequest>
    {
        [Required]
        public long UserId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string RegisterCode { get; set; }
        [Required]
        public DateTime RegisterDate { get; set; }
        public List<AddCompanyLanguageDataRequest> LanguageDatas { get; set; } = new();
    }
}
