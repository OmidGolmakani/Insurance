using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Configs.AutoMapper.Global
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            #region Requests
            CreateMap<Models.Dtos.Requests.Users.AddUserRequest, Models.Entities.User>().ReverseMap();
            CreateMap<Models.Dtos.Requests.Users.EditUserRequest, Models.Entities.User>().ReverseMap();
            CreateMap<Models.Dtos.Requests.Users.DeleteUserRequest, Models.Entities.User>().ReverseMap();
            CreateMap<Models.Dtos.Requests.Users.GetUserRequest, Models.Entities.User>().ReverseMap();
            CreateMap<Models.Dtos.Requests.Users.GetUsersRequest, Models.Entities.User>().ReverseMap();
            CreateMap<Models.Dtos.Requests.Users.AddUserToRoleRequest, Models.Entities.User>().ReverseMap();
            CreateMap<Models.Dtos.Requests.Users.LoginRequst, Models.Entities.User>().ReverseMap();
            CreateMap<Models.Dtos.Requests.Users.UniqueEmailValodationRequest, Models.Entities.User>().ReverseMap();
            CreateMap<Models.Dtos.Requests.Users.UniquePhoneNumber, Models.Entities.User>().ReverseMap();
            CreateMap<Models.Dtos.Requests.Users.UniqueUserValidationRequst, Models.Entities.User>().ReverseMap();
            CreateMap<Models.Dtos.Requests.Users.VerifyEmail, Models.Entities.User>().ReverseMap();
            CreateMap<Models.Dtos.Requests.Users.VerifyPhoneNumber, Models.Entities.User>().ReverseMap();
            #endregion Requests
            #region Responses
            CreateMap<Models.Dtos.Responses.Users.UserResponse, Models.Entities.User>().ReverseMap(); 
            #endregion Responses

        }
    }
}
