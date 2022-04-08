using AutoMapper;
using Domain.Data.DbContext;
using Domain.Interfaces.Globals.Repositories;
using Domain.Models.Dtos.Requests.UserDetailFieldLanguageDatas;
using Domain.Models.Dtos.Responses.UserDetailFieldLanguageDatas;
using Domain.Models.Entities;
using Domain.Repositories.Fundamentals;
using Microsoft.AspNetCore.Http;

namespace Domain.Repositories
{
    public class UserDetailFieldLanguageDataRepository : Repository<long, 
                                                                   UserDetailFieldLanguageData, 
                                                                   GetUserDetailFieldLanguageDataRequest, 
                                                                   GetUserDetailFieldsLanguageDataRequest, 
                                                                   UserDetailFieldLanguageDataResponse>, 
                                                                   IUserDetailFieldLanguageDataRepository
    {
        public UserDetailFieldLanguageDataRepository(DbFactory dbFactory,
                                                    IMapper mapper,
                                                    IHttpContextAccessor httpContext)
            : base(dbFactory, mapper, httpContext)
        {
        }
    }
}
