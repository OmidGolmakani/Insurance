using AutoMapper;
using Domain.Models.Dtos.Responses.UserDetailFieldLanguageDatas;

namespace Domain.Configs.AutoMapper.Global
{
    public class UserDetailFieldLanguageDataProfile : Profile
    {
        public UserDetailFieldLanguageDataProfile()
        {
            #region Reuests
            CreateMap<Models.Dtos.Requests.UserDetailFieldLanguageDatas.AddUserDetailFieldLanguageDataRequest, Models.Entities.UserDetailFieldLanguageData>().ReverseMap();
            CreateMap<Models.Dtos.Requests.UserDetailFieldLanguageDatas.EditUserDetailFieldLanguageDataRequest, Models.Entities.UserDetailFieldLanguageData>().ReverseMap();
            CreateMap<Models.Dtos.Requests.UserDetailFieldLanguageDatas.DeleteUserDetailFieldLanguageDataRequest, Models.Entities.UserDetailFieldLanguageData>().ReverseMap();
            CreateMap<Models.Dtos.Requests.UserDetailFieldLanguageDatas.GetUserDetailFieldLanguageDataRequest, Models.Entities.UserDetailFieldLanguageData>().ReverseMap();
            CreateMap<Models.Dtos.Requests.UserDetailFieldLanguageDatas.GetUserDetailFieldsLanguageDataRequest, Models.Entities.UserDetailFieldLanguageData>().ReverseMap();
            #endregion Reuests
            #region Responses
            CreateMap<Models.Dtos.Responses.UserDetailFieldLanguageDatas.UserDetailFieldLanguageDataResponse, Models.Entities.UserDetailFieldLanguageData>().ReverseMap();
            //CreateMap<Models.Views.V_UserDetailField, UserDetailFieldLanguageDataResponse>()
            //     .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.OtherLanguageId))
            //     .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.OtherLanguageName))
            //     .ForMember(dest => dest.Description, opts => opts.MapFrom(src => src.OtherLanguageName));

            #endregion Responses

        }
    }
}
