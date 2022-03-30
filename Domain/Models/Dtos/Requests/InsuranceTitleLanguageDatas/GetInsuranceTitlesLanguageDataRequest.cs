using Domain.Models.Dtos.Fundamentals.Requests;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Dtos.Requests.InsuranceTitleLanguageDatas
{
    public class GetInsuranceTitlesLanguageDataRequest : GetsRequest
    {
        public int KeyId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
