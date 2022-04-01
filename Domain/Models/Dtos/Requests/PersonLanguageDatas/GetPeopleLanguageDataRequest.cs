using Domain.Interfaces.Fundamentals.Request;
using Domain.Models.Dtos.Fundamentals.Requests;
using System;

namespace Domain.Models.Dtos.Requests.PersonLanguageDatas
{
    public class GetPeopleLanguageDataRequest : GetsRequest, IGetsLanguageDataRequest<long>
    {
        public long? KeyId { get; set; }
        public int? LanguageId { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
    }
}
