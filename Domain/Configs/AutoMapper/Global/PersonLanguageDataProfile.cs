using AutoMapper;
using Domain.Models.Dtos.Responses.PersonLanguageDatas;

namespace Domain.Configs.AutoMapper.Global
{
    public class PersonLanguageDataProfile : Profile
    {
        public PersonLanguageDataProfile()
        {
            #region Reuests
            CreateMap<Models.Dtos.Requests.PersonLanguageDatas.AddPersonLanguageDataRequest, Models.Entities.PersonLanguageData>().ReverseMap();
            CreateMap<Models.Dtos.Requests.PersonLanguageDatas.EditPersonLanguageDataRequest, Models.Entities.PersonLanguageData>().ReverseMap();
            CreateMap<Models.Dtos.Requests.PersonLanguageDatas.DeletePersonLanguageDataRequest, Models.Entities.PersonLanguageData>().ReverseMap();
            CreateMap<Models.Dtos.Requests.PersonLanguageDatas.GetPersonLanguageDataRequest, Models.Entities.PersonLanguageData>().ReverseMap();
            CreateMap<Models.Dtos.Requests.PersonLanguageDatas.GetPeopleLanguageDataRequest, Models.Entities.PersonLanguageData>().ReverseMap();
            #endregion Reuests
            #region Responses
            CreateMap<Models.Dtos.Responses.PersonLanguageDatas.PersonLanguageDataResponse, Models.Entities.PersonLanguageData>().ReverseMap();

            #endregion Responses

        }
    }
}
