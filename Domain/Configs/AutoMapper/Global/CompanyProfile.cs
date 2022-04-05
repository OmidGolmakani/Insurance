using AutoMapper;

namespace Domain.Configs.AutoMapper.Global
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            #region Reuests
            CreateMap<Models.Dtos.Requests.Companies.AddCompanyRequest, Models.Entities.Company>()
                 .ForMember(dest => dest.CompanyLanguageDatas, opts => opts.MapFrom(src => src.LanguageDatas));

            CreateMap<Models.Entities.Company,Models.Dtos.Requests.Companies.AddCompanyRequest>();


            CreateMap<Models.Dtos.Requests.Companies.EditCompanyRequest, Models.Entities.Company>()
                 .ForMember(dest => dest.CompanyLanguageDatas, opts => opts.MapFrom(src => src.LanguageDatas));

            CreateMap<Models.Entities.Company, Models.Dtos.Requests.Companies.EditCompanyRequest>();

            CreateMap<Models.Dtos.Requests.Companies.DeleteCompanyRequest, Models.Entities.Company>().ReverseMap();
            CreateMap<Models.Dtos.Requests.Companies.GetCompanyRequest, Models.Entities.Company>().ReverseMap();
            CreateMap<Models.Dtos.Requests.Companies.GetCompaniesRequest, Models.Entities.Company>().ReverseMap();
            #endregion Reuests
            #region Responses
            CreateMap<Models.Dtos.Responses.Companies.CompanyResponse, Models.Entities.Company>().ReverseMap(); 
            #endregion Responses

        }
    }
}
