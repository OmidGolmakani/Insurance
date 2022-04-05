using Domain.Interfaces.Fundamentals.Request;
using Domain.Models.Dtos.Fundamentals.Requests;

namespace Domain.Models.Dtos.Requests.CompanyLanguageDatas
{
    public class GetCompaniesLanguageDataRequest : GetsRequest, IGetsLanguageDataRequest<long>
    {
        public long? KeyId { get; set; }
        public int? LanguageId { get; set; }
        public string RegisterCode { get; set; }
        public string Name { get; set; }
    }
}
