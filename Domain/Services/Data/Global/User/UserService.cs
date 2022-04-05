using AutoMapper;
using Domain.Interfaces.Fundamentals.Repository;
using Domain.Interfaces.Globals.DataServices;
using Domain.Interfaces.Globals.Repositories;
using Domain.Models.Dtos.Requests.Users;
using Domain.Models.Dtos.Responses.Users;
using Domain.Models.Entities;
using Domain.Services.Data.Fundamentals;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Services.Data.Global
{
    public class UserService : Service<long,
                                       User,
                                       GetUserRequest,
                                       GetUsersRequest,
                                       UserResponse,
                                       AddUserRequest,
                                       EditUserRequest,
                                       DeleteUserRequest>,
        IUserService
    {
        private readonly IRepository<long, User, GetUserRequest, GetUsersRequest, UserResponse> _repository;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<User> _validator;

        public UserService(IRepository<long, User, GetUserRequest, GetUsersRequest, UserResponse> repository,
                           IUserRepository userRepository,
                           IMapper mapper,
                           IUnitOfWork unitOfWork,
                           IValidator<User> validator) :
            base(repository, mapper, unitOfWork, validator)
        {
            this._repository = repository;
            this._userRepository = userRepository;
            this._mapper = mapper;
            this._unitOfWork = unitOfWork;
            this._validator = validator;
        }
        public Task<List<IdentityResult>> AddUserToRole(AddUserToRoleRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<string>> GetUserRolesAsync(GetUserRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> isUniqueEmailAsync(UniqueEmailValodationRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> isUniquePhoneNumberAsync(UniquePhoneNumber request)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> isUniqueUserAsync(UniqueUserValidationRequst request)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> PhoneNumberConfirmation(string PhoneNumber)
        {
            throw new System.NotImplementedException();
        }

        public async Task<SigninResponse> SignInAsync(LoginRequst request)
        {
            return await _userRepository.SigninAsync(request);
        }

        public async Task SignoutAsync()
        {
            await _userRepository.SignoutAsync();
        }

        public Task<IdentityResult> VerifyPhoneNumber(string PhoneNumber, string Token)
        {
            throw new System.NotImplementedException();
        }
        public async override Task<UserResponse> Add(AddUserRequest request)
        {
            var entity = _mapper.Map<AddUserRequest, Models.Entities.User>(request);
            entity.PasswordHash = request.Password;
            entity.PhoneNumberConfirmed = true;
            await _validator.ValidateAndThrowAsync(entity);
            entity = _repository.Add(entity);
            var resopnse = _mapper.Map<UserResponse>(entity);
            return resopnse;
        }
        public override Task BatchDelete(IEnumerable<DeleteUserRequest> request)
        {
            return base.BatchDelete(request);
        }
        public async override Task<UserResponse> Update(EditUserRequest request)
        {
            var entity = _mapper.Map<EditUserRequest, Models.Entities.User>(request);
            await _validator.ValidateAndThrowAsync(entity);
            _repository.Update(entity);
            entity = _repository.Update(entity);
            UserResponse response = new();
            _mapper.Map<Models.Entities.User, UserResponse>(entity, response);
            return response;
        }
    }
}
