using Domain.Interfaces.Fundamentals.Response;
using Domain.Models.Dtos.Fundamentals.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Dtos.Responses.InsuranceTitleLanguageDatas
{
    public class InsuranceTitleLanguageDataResponse : BaseResponse<long>, ILanguageDataResponse<int>
    {
        public int KeyId { get; set; }
        public int LanguageId { get; set; }
        public string AcceptLanguage { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
