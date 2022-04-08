using AutoMapper;
using Domain.Models.Entities;
using Domain.Interfaces.Fundamentals.Repository;
using Domain.Interfaces.Globals.DataServices;
using Domain.Models.Dtos.Requests.UserDetailFields;
using Domain.Models.Dtos.Responses.UserDetailFields;
using Domain.Services.Data.Fundamentals;
using FluentValidation;

namespace Domain.Services.Data.Global
{
    public class UserDetailFieldService : Service<long,
                                          UserDetailField,
                                          GetUserDetailFieldRequest,
                                          GetUserDetailFieldsRequest,
                                          UserDetailFieldResponse,
                                          AddUserDetailFieldRequest,
                                          EditUserDetailFieldRequest,
                                          DeleteUserDetailFieldRequest>, 
        IUserDetailFieldService
    {
        public UserDetailFieldService(IRepository<long,
                                                   UserDetailField,
                                                   GetUserDetailFieldRequest,
                                                   GetUserDetailFieldsRequest,
                                                   UserDetailFieldResponse> repository,
            IMapper mapper, IUnitOfWork unitOfWork, IValidator<UserDetailField> validator) :
            base(repository, mapper, unitOfWork, validator)
        {
        }
    }
}
