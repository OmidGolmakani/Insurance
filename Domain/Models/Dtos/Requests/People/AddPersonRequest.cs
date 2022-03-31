using Domain.Interfaces.Fundamentals.Request;
using Domain.Models.Dtos.Fundamentals.Requests;
using Domain.Models.Dtos.Requests.InsuranceTitleLanguageDatas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Dtos.Requests.People
{
    public class AddPersonRequest : AddRequest, IListDataLanguageRequest<long, AddInsuranceTitleLanguageDataRequest>
    {
        [Required]
        public long UserId { get; set; }
        [Required]
        public byte Gender { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Family { get; set; }
        public DateTime? BirthDate { get; set; }
        public List<AddInsuranceTitleLanguageDataRequest> LanguageDatas { get; set; }
    }
}
