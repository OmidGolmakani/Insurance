using AutoMapper;
using Domain.Models.Dtos.Responses.InsuranceTitleLanguageDatas;

namespace Domain.Configs.AutoMapper.Global
{
    public class InsuranceTitleLanguageDataProfile : Profile
    {
        public InsuranceTitleLanguageDataProfile()
        {
            #region Reuests
            //CreateMap<Models.Dtos.Requests.InsuranceTitles.AddInsuranceTitleRequest, Models.Entities.InsuranceTitle>().ReverseMap();
            //CreateMap<Models.Dtos.Requests.InsuranceTitles.EditInsuranceTitleRequest, Models.Entities.InsuranceTitle>().ReverseMap();
            //CreateMap<Models.Dtos.Requests.InsuranceTitles.DeleteInsuranceTitleRequest, Models.Entities.InsuranceTitle>().ReverseMap();
            //CreateMap<Models.Dtos.Requests.InsuranceTitles.GetInsuranceTitleRequest, Models.Entities.InsuranceTitle>().ReverseMap();
            //CreateMap<Models.Dtos.Requests.InsuranceTitles.GetInsuranceTitlesRequest, Models.Entities.InsuranceTitle>().ReverseMap();
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
