using Domain.Interfaces.Fundamentals.Response;
using Domain.Models.Dtos.Fundamentals.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Models.Dtos.Responses.PersonLanguageDatas
{
    public class PersonLanguageDataResponse : BaseResponse<long>, ILanguageDataResponse<long>
    {
        [JsonIgnore]
        public override long Id { get => base.Id; set => base.Id = value; }
        [JsonPropertyName(nameof(Id))]
        public long OtherLanguageId { get; set; }
        [JsonIgnore]
        public long KeyId { get; set; }
        public int LanguageId { get; set; }
        [JsonPropertyName("Name")]
        public string OtherLanguageName { get; set; }
        [JsonPropertyName("Family")]
        public string OtherLanguageFamily { get; set; }
        public string AcceptLanguage { get; set; }
    }
}
