using Domain.Interfaces.Fundamentals.Request;
using Domain.Models.Dtos.Fundamentals.Requests;
using Domain.Models.Dtos.Requests.InsuranceTitleLanguageDatas;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Dtos.Requests.InsuranceTitles
{
    public class EditInsuranceTitleRequest : EditRequest<int>, IListDataLanguageRequest<long, EditInsuranceTitleLanguageDataRequest>
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
        public List<EditInsuranceTitleLanguageDataRequest> LanguageDatas { get; set; }
    }
}
