using Domain.Interfaces.Fundamentals.Response;
using Domain.Models.Dtos.Fundamentals.Response;
using Domain.Models.Dtos.Responses.InsuranceTitleLanguageDatas;
using Domain.Models.Dtos.Responses.PersonLanguageDatas;
using System;
using System.Collections.Generic;

namespace Domain.Models.Dtos.Responses.People
{
    public class PersonResponse : BaseResponse<long>, ILisDataLanguageResponse<long, PersonLanguageDataResponse>
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public byte Gender { get; set; }
        public string GenderTitle { get 
            {
               return  Helpers.Globals.Enumerated.Find(typeof(Models.Enums.Person), this.Gender); 
            }}
        public string Name { get; set; }
        public string Family { get; set; }
        public DateTime BirthDate { get; set; }
        public List<PersonLanguageDataResponse> LanguageDatas { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}
