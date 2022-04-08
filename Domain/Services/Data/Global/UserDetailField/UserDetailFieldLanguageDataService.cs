using AutoMapper;
using Domain.Interfaces.Fundamentals.Repository;
using Domain.Interfaces.Globals.DataServices;
using Domain.Models.Dtos.Requests.UserDetailFieldLanguageDatas;
using Domain.Models.Dtos.Responses.UserDetailFieldLanguageDatas;
using Domain.Models.Entities;
using Domain.Services.Data.Fundamentals;
using FluentValidation;

namespace Domain.Services.Data.Global
{
    public class UserDetailFieldLanguageDataService : Service<long,
                                                      UserDetailFieldLanguageData,
                                                      GetUserDetailFieldLanguageDataRequest,
                                                      GetUserDetailFieldsLanguageDataRequest,
                                                      UserDetailFieldLanguageDataResponse,
                                                      AddUserDetailFieldLanguageDataRequest,
                                                      EditUserDetailFieldLanguageDataRequest,
                                                      DeleteUserDetailFieldLanguageDataRequest>,
        IUserDetailFieldLanguageDataService
    {
        public UserDetailFieldLanguageDataService(IRepository<long,
                                                  UserDetailFieldLanguageData,
                                                  GetUserDetailFieldLanguageDataRequest,
                                                  GetUserDetailFieldsLanguageDataRequest,
                                                  UserDetailFieldLanguageDataResponse> repository,
            IMapper mapper, IUnitOfWork unitOfWork, IValidator<UserDetailFieldLanguageData> validator) :
            base(repository, mapper, unitOfWork, validator)
        {
        }
    }
}
