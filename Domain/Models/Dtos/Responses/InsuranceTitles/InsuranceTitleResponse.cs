using Domain.Interfaces.Fundamentals.Response;
using Domain.Models.Dtos.Fundamentals.Response;
using Domain.Models.Dtos.Responses.InsuranceTitleLanguageDatas;
using System.Collections.Generic;

namespace Domain.Models.Dtos.Responses.InsuranceTitles
{
    public class InsuranceTitleResponse : BaseResponse<int>, ILisDataLanguageResponse<int,InsuranceTitleLanguageDataResponse>
    {
        public decimal? Code { get; set; }
        public int? ParentId { get; set; }
        public byte level { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public List<InsuranceTitleLanguageDataResponse> LanguageDatas { get; set; } = new();
    }
}
