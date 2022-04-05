using AutoMapper;
using Domain.Models.Dtos.Responses.CompanyLanguageDatas;

namespace Domain.Configs.AutoMapper.Global
{
    public class CompanyLanguageDataProfile : Profile
    {
        public CompanyLanguageDataProfile()
        {
            #region Reuests
            CreateMap<Models.Dtos.Requests.CompanyLanguageDatas.AddCompanyLanguageDataRequest, Models.Entities.CompanyLanguageData>().ReverseMap();
            CreateMap<Models.Dtos.Requests.CompanyLanguageDatas.EditCompanyLanguageDataRequest, Models.Entities.CompanyLanguageData>().ReverseMap();
            CreateMap<Models.Dtos.Requests.CompanyLanguageDatas.DeleteCompanyLanguageDataRequest, Models.Entities.CompanyLanguageData>().ReverseMap();
            CreateMap<Models.Dtos.Requests.CompanyLanguageDatas.GetCompanyLanguageDataRequest, Models.Entities.CompanyLanguageData>().ReverseMap();
            CreateMap<Models.Dtos.Requests.CompanyLanguageDatas.GetCompaniesLanguageDataRequest, Models.Entities.CompanyLanguageData>().ReverseMap();
            #endregion Reuests
            #region Responses
            CreateMap<Models.Dtos.Responses.CompanyLanguageDatas.CompanyLanguageDataResponse, Models.Entities.CompanyLanguageData>().ReverseMap();
            //CreateMap<Models.Views.V_Company, CompanyLanguageDataResponse>()
            //     .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.OtherLanguageId))
            //     .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.OtherLanguageName))
            //     .ForMember(dest => dest.Description, opts => opts.MapFrom(src => src.OtherLanguageName));

            #endregion Responses

        }
    }
}
