using AutoMapper;
using Domain.Data.DbContext;
using Domain.Interfaces.Globals.Repositores;
using Domain.Models.Dtos.Requests.Users;
using Domain.Models.Dtos.Responses.Users;
using Domain.Models.Entities;
using Domain.Repositories.Fundamentals;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class UserRepository : Repository<long, User, GetUserRequest, GetUsersRequest, UserResponse>, IUserRepository
    {
        private readonly UserManager<User> _user;

        public UserRepository(DbFactory dbFactory,
                              IMapper mapper,
                              UserManager<User> user) : base(dbFactory, mapper)
        {
            this._user = user;
        }

        public async Task<bool> isUniqueEmailAsync(UniqueEmailValodationRequest request)
        {
            return await _user.Users.Where(p => p.Id != request.Id).CountAsync(p => p.PhoneNumber == request.Email) != 0 ? true : false;
        }

        public async Task<bool> isUniquePhoneNumberAsync(UniquePhoneNumber request)
        {
            return await _user.Users.Where(p => p.Id != request.Id).CountAsync(p => p.PhoneNumber == request.PhoneNumber) != 0 ? true : false;
        }

        public async Task<bool> isUniqueUserAsync(UniqueUserValidationRequst request)
        {
            return await _user.Users.Where(p => p.Id != request.Id).CountAsync(p => p.UserName == request.UserName) != 0 ? true : false;
        }

        public async Task<SigninResponse> SigninAsync(LoginRequst requst)
        {
            throw new NotImplementedException();
        }

        public async Task SignoutAsync()
        {
            throw new NotImplementedException();
        }
    }
}
