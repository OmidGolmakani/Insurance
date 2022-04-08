using AutoMapper;
using Domain.Data.DbContext;
using Domain.Interfaces.Globals.Repositories;
using Domain.Models.Dtos.Requests.UserDetailFields;
using Domain.Models.Dtos.Responses.UserDetailFields;
using Domain.Models.Entities;
using Domain.Repositories.Fundamentals;
using Microsoft.AspNetCore.Http;

namespace Domain.Repositories
{
    public class UserDetailFieldRepository : Repository<long,
                                                        UserDetailField,
                                                        GetUserDetailFieldRequest,
                                                        GetUserDetailFieldsRequest,
                                                        UserDetailFieldResponse>,
        IUserDetailFieldRepository
    {
        public UserDetailFieldRepository(DbFactory dbFactory,
                                        IMapper mapper,
                                        IHttpContextAccessor httpContext)
            : base(dbFactory, mapper, httpContext)
        {
        }
    }
}
