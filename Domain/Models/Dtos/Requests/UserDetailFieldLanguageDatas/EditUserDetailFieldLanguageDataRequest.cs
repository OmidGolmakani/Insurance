using Domain.Interfaces.Fundamentals.Request;
using Domain.Models.Dtos.Fundamentals.Requests;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Domain.Models.Dtos.Requests.UserDetailFieldLanguageDatas
{
    public class EditUserDetailFieldLanguageDataRequest : EditRequest<long>, ILanguageDataRequest<long>
    {
        [Required]
        [JsonIgnore]
        public long KeyId { get; set; }
        [Required]
        public int LanguageId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
