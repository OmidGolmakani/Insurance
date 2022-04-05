using Domain.Interfaces.Fundamentals.Response;
using Domain.Models.Dtos.Fundamentals.Response;
using Domain.Models.Dtos.Responses.CompanyLanguageDatas;
using System;
using System.Collections.Generic;

namespace Domain.Models.Dtos.Responses.Companies
{
    public class CompanyResponse : BaseResponse<long>, ILisDataLanguageResponse<long, CompanyLanguageDataResponse>
    {
        public long UserId { get; set; }
        public string Name { get; set; }
        public string RegisterCode { get; set; }
        public DateTime RegisterDate { get; set; }
        public List<CompanyLanguageDataResponse> LanguageDatas { get; set; }
    }
}
