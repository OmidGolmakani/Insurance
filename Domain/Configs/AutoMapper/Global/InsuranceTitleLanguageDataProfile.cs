using AutoMapper;
using Domain.Models.Dtos.Responses.InsuranceTitleLanguageDatas;

namespace Domain.Configs.AutoMapper.Global
{
    public class InsuranceTitleLanguageDataProfile : Profile
    {
        public InsuranceTitleLanguageDataProfile()
        {
            #region Reuests
            CreateMap<Models.Dtos.Requests.InsuranceTitleLanguageDatas.AddInsuranceTitleLanguageDataRequest, Models.Entities.InsuranceTitleLanguageData>().ReverseMap();
            CreateMap<Models.Dtos.Requests.InsuranceTitleLanguageDatas.EditInsuranceTitleLanguageDataRequest, Models.Entities.InsuranceTitleLanguageData>().ReverseMap();
            CreateMap<Models.Dtos.Requests.InsuranceTitleLanguageDatas.DeleteInsuranceTitleLanguageDataRequest, Models.Entities.InsuranceTitleLanguageData>().ReverseMap();
            CreateMap<Models.Dtos.Requests.InsuranceTitleLanguageDatas.GetInsuranceTitleLanguageDataRequest, Models.Entities.InsuranceTitleLanguageData>().ReverseMap();
            CreateMap<Models.Dtos.Requests.InsuranceTitleLanguageDatas.GetInsuranceTitlesLanguageDataRequest, Models.Entities.InsuranceTitleLanguageData>().ReverseMap();
            #endregion Reuests
            #region Responses
            CreateMap<Models.Dtos.Responses.InsuranceTitleLanguageDatas.InsuranceTitleLanguageDataResponse, Models.Entities.InsuranceTitleLanguageData>().ReverseMap();
            //CreateMap<Models.Views.V_InsuranceTitle, InsuranceTitleLanguageDataResponse>()
            //     .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.OtherLanguageId))
            //     .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.OtherLanguageName))
            //     .ForMember(dest => dest.Description, opts => opts.MapFrom(src => src.OtherLanguageName));

            #endregion Responses

        }
    }
}
