using AutoMapper;
using Domain.CustomException;
using Domain.Interfaces.Fundamentals.Repository;
using Domain.Interfaces.Globals.DataServices;
using Domain.Interfaces.Globals.Repositores;
using Domain.Messages;
using Domain.Models.Dtos.Fundamentals.Response;
using Domain.Models.Dtos.Requests.Users;
using Domain.Models.Dtos.Responses.Users;
using Domain.Models.Validations.User;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Services.Data.Global
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository,
                           IUnitOfWork unitOfWork,
                           IMapper mapper)
        {
            this._userRepository = userRepository;
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }
        public async Task<UserResponse> Add(AddUserRequest request)
        {
            var entity = _mapper.Map<Domain.Models.Entities.User>(request);
            entity.PasswordHash = request.Password;
            entity.PhoneNumberConfirmed = true;
            UserValidation validator = new UserValidation(this, _mapper);
            await validator.ValidateAndThrowAsync(entity);
            _userRepository.Add(entity);
            return _mapper.Map<UserResponse>(entity);
        }

        public Task<List<IdentityResult>> AddUserToRole(AddUserToRoleRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task BatchDelete(IEnumerable<DeleteUserRequest> request)
        {
            var entites = _mapper.Map<IEnumerable<Domain.Models.Entities.User>>(request);
            _userRepository.DeleteBatch(entites);
            await Task.Delay(0);
        }

        public async Task BatchUpdate(IEnumerable<EditUserRequest> request)
        {
            var entites = _mapper.Map<IEnumerable<Domain.Models.Entities.User>>(request);
            _userRepository.UpdateBatch(entites);
            await Task.Delay(0);
        }

        public async Task<int> CountAsync(GetUsersRequest request, bool includeDeleted = false)
        {
            return await _userRepository.CountAsync(request);
        }

        public async Task Delete(DeleteUserRequest request)
        {
            Domain.Models.Entities.User entity = new();
            _mapper.Map<UserResponse, Domain.Models.Entities.User>(await _userRepository.GetById(_mapper.Map<GetUserRequest>(request)), entity);
            if (entity == null)
                throw new MyException(System.Net.HttpStatusCode.NotFound, GlobalMessags.UserNotFound);
            _mapper.Map<DeleteUserRequest, Domain.Models.Entities.User>(request, entity);
            entity.LockoutEnabled = true;
            entity.LockoutEnd = DateTimeOffset.MaxValue;
            _userRepository.Delete(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task<UserResponse> GetById(GetUserRequest request, bool IncludeDeleted = false)
        {
            return _mapper.Map<UserResponse>(await _userRepository.GetById(request,IncludeDeleted));
        }

        public Task<ListResponse<UserResponse>> Get(GetUsersRequest request, bool includeDeleted = false)
        {
            throw new NotImplementedException();
        }

        public async Task<ListResponse<UserResponse>> GetsAsync(GetUsersRequest request, bool includeDeleted = false)
        {
            var items = _mapper.Map<List<UserResponse>>((await _userRepository.Get(request)));
            return new ListResponse<UserResponse>() { Items = items, Total = items.Count() };
        }

        public Task<IList<string>> GetUserRolesAsync(GetUserRequest request, bool includeDeleted = false)
        {
            throw new NotImplementedException();
        }

        public Task<IList<string>> GetUserRolesAsync(GetUserRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> isUniqueEmailAsync(UniqueEmailValodationRequest request)
        {
            return await _userRepository.isUniqueEmailAsync(request);
        }

        public Task<bool> isUniquePhoneNumberAsync(UniquePhoneNumber request)
        {
            return _userRepository.isUniquePhoneNumberAsync(request);
        }

        public async Task<bool> isUniqueUserAsync(UniqueUserValidationRequst request)
        {
            return await _userRepository.isUniqueUserAsync(request);
        }

        public Task<string> PhoneNumberConfirmation(string PhoneNumber)
        {
            throw new NotImplementedException();
        }

        public async Task<SigninResponse> SignInAsync(LoginRequst request)
        {
            return await _userRepository.SigninAsync(request);
        }

        public async Task SignoutAsync()
        {
            await _userRepository.SignoutAsync();
        }

        public async Task<UserResponse> Update(EditUserRequest request)
        {
            Domain.Models.Entities.User entity = new();
            _mapper.Map<UserResponse, Domain.Models.Entities.User>(await _userRepository.GetById(_mapper.Map<GetUserRequest>(request)), entity);
            if (entity == null)
                throw new MyException(System.Net.HttpStatusCode.NotFound, GlobalMessags.UserNotFound);
            _mapper.Map<EditUserRequest, Domain.Models.Entities.User>(request, entity);
            UserValidation validator = new UserValidation(this, _mapper);
            await validator.ValidateAndThrowAsync(entity);
            _userRepository.Update(entity);
            var model = new UserResponse();
            await Task.Delay(0);
            return _mapper.Map<Domain.Models.Entities.User, UserResponse>(entity, model);
        }

        public Task<IdentityResult> VerifyPhoneNumber(string PhoneNumber, string Token)
        {
            throw new NotImplementedException();
        }
    }
}
