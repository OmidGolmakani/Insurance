using Domain.Interfaces.Fundamentals.Request;
using Domain.Models.Dtos.Fundamentals.Requests;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Domain.Models.Dtos.Requests.InsuranceTitleLanguageDatas
{
    public class AddCompanyLanguageDataRequest : AddRequest, ILanguageDataRequest<long>
    {
        [Required]
        [JsonIgnore]
        public long KeyId { get; set; }
        [Required]
        public int LanguageId { get; set; }
        [Required]
        public string RegisterCode { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
