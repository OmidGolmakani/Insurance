using Domain.Interfaces.Fundamentals.Request;
using Domain.Models.Dtos.Fundamentals.Requests;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Dtos.Requests.PersonLanguageDatas
{
    public class EditPersonLanguageDataRequest : EditRequest<long>, ILanguageDataRequest<long>
    {
        public long KeyId { get; set; }
        public int LanguageId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Family { get; set; }
    }
}
