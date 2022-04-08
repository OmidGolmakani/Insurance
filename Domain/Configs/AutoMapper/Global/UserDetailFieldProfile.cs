using AutoMapper;

namespace Domain.Configs.AutoMapper.Global
{
    public class UserDetailFieldProfile : Profile
    {
        public UserDetailFieldProfile()
        {
            #region Reuests
            CreateMap<Models.Dtos.Requests.UserDetailFields.AddUserDetailFieldRequest, Models.Entities.UserDetailField>()
                 .ForMember(dest => dest.UserDetailFieldLanguageDatas, opts => opts.MapFrom(src => src.LanguageDatas));

            CreateMap<Models.Entities.UserDetailField,Models.Dtos.Requests.UserDetailFields.AddUserDetailFieldRequest>();


            CreateMap<Models.Dtos.Requests.UserDetailFields.EditUserDetailFieldRequest, Models.Entities.UserDetailField>()
                 .ForMember(dest => dest.UserDetailFieldLanguageDatas, opts => opts.MapFrom(src => src.LanguageDatas));

            CreateMap<Models.Entities.UserDetailField, Models.Dtos.Requests.UserDetailFields.EditUserDetailFieldRequest>();

            CreateMap<Models.Dtos.Requests.UserDetailFields.DeleteUserDetailFieldRequest, Models.Entities.UserDetailField>().ReverseMap();
            CreateMap<Models.Dtos.Requests.UserDetailFields.GetUserDetailFieldRequest, Models.Entities.UserDetailField>().ReverseMap();
            CreateMap<Models.Dtos.Requests.UserDetailFields.GetUserDetailFieldsRequest, Models.Entities.UserDetailField>().ReverseMap();
            #endregion Reuests
            #region Responses
            CreateMap<Models.Dtos.Responses.UserDetailFields.UserDetailFieldResponse, Models.Entities.UserDetailField>().ReverseMap(); 
            #endregion Responses

        }
    }
}
