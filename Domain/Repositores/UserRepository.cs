using AutoMapper;
using Domain.CustomException;
using Domain.Data.DbContext;
using Domain.Interfaces.Globals.Repositories;
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
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class UserRepository : Repository<long, User, GetUserRequest, GetUsersRequest, UserResponse>, IUserRepository
    {
        private readonly IMapper _mapper;
        private readonly UserManager<User> _user;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public UserRepository(DbFactory dbFactory,
                              IMapper mapper,
                              UserManager<User> user,
                              UserManager<User> userManager,
                              SignInManager<User> signInManager) : base(dbFactory, mapper)
        {
            this._mapper = mapper;
            this._user = user;
            this._userManager = userManager;
            this._signInManager = signInManager;
        }
        public override User Add(User entity)
        {
            base.Add(entity);
            entity.PasswordHash = _userManager.PasswordHasher.HashPassword(entity, entity.PasswordHash);
            var result = _userManager.CreateAsync(entity).Result;
            if (result.Succeeded == false)
            {
                throw new MyException(Newtonsoft.Json.JsonConvert.SerializeObject(result.Errors));
            }
            return entity;
        }
        public override User Update(User entity)
        {
            _userManager.UpdateAsync(entity);
            return entity;
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
            var user = await _userManager.FindByNameAsync(requst.UserName);
            var signIn = await this._signInManager.PasswordSignInAsync(requst.UserName, requst.Password, requst.isPersistent, true);
            List<string> userRoles = (List<string>)await _user.GetRolesAsync(user);
            var token = Helpers.Globals.JWTTokenManager.GenerateToken(user, userRoles);
            return new SigninResponse()
            {
                Id = user.Id,
                SignIn = signIn,
                Token = token,
                IsAdmin = userRoles.Any(u => u == Helpers.ConstVariables.Globals.AdministratorRoleName)
            };
        }

        public async Task SignoutAsync()
        {
            throw new NotImplementedException();
        }
    }
}
