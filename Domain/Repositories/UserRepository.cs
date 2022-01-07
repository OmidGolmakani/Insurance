using AutoMapper;
using Domain.Data.DbContext;
using Domain.Interfaces.Globals.Repositores;
using Domain.Models.Dtos.Requests.Users;
using Domain.Models.Dtos.Responses.Users;
using Domain.Models.Entities;
using Domain.Repositories.Fundamentals;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class UserRepository : Repository<long, AspNetUsers, GetUserRequest, GetUsersRequest, UserResponse>, IUserRepository
    {
        public UserRepository(DbFactory dbFactory, IMapper mapper) : base(dbFactory, mapper)
        {
        }

        public Task<bool> isUniqueEmailAsync(UniqueEmailValodationRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> isUniquePhoneNumberAsync(UniquePhoneNumber request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> isUniqueUserAsync(UniqueUserValidationRequst request)
        {
            throw new NotImplementedException();
        }

        public Task<SigninResponse> SigninAsync(LoginRequst requst)
        {
            throw new NotImplementedException();
        }

        public Task SignoutAsync()
        {
            throw new NotImplementedException();
        }
    }
}
