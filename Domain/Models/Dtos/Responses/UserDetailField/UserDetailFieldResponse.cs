using Domain.Interfaces.Fundamentals.Response;
using Domain.Models.Dtos.Fundamentals.Response;
using Domain.Models.Dtos.Responses.UserDetailFieldLanguageDatas;
using System.Collections.Generic;

namespace Domain.Models.Dtos.Responses.UserDetailFields
{
    public class UserDetailFieldResponse : BaseResponse<long>, ILisDataLanguageResponse<long,UserDetailFieldLanguageDataResponse>
    {
        public decimal? Code { get; set; }
        public int? ParentId { get; set; }
        public byte level { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public List<UserDetailFieldLanguageDataResponse> LanguageDatas { get; set; } = new();
    }
}
