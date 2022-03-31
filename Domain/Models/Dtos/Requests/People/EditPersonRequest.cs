using Domain.Interfaces.Fundamentals.Request;
using Domain.Models.Dtos.Fundamentals.Requests;
using Domain.Models.Dtos.Requests.PersonLanguageDatas;
using System;
using System.Collections.Generic;

namespace Domain.Models.Dtos.Requests.People
{
    public class EditPersonRequest : EditRequest<long>, IListDataLanguageRequest<long, EditPersonLanguageDataRequest>
    {
        public long UserId { get; set; }
        public byte Gender { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public DateTime? BirthDate { get; set; }
        public List<EditPersonLanguageDataRequest> LanguageDatas { get; set; }
    }
}
