﻿using Domain.Interfaces.Fundamentals.Response;
using Domain.Models.Dtos.Fundamentals.Response;
using System.Text.Json.Serialization;

namespace Domain.Models.Dtos.Responses.UserDetailFieldLanguageDatas
{
    public class UserDetailFieldLanguageDataResponse : BaseResponse<long>, ILanguageDataResponse<long>
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
        [JsonPropertyName("Description")]
        public string OtherLanguageDescription { get; set; }
        public string AcceptLanguage { get; set; }
    }
}
