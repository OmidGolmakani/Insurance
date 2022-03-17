using AutoMapper;
using Domain.Interfaces.Globals.DataServices;
using FluentValidation;
using System.Threading.Tasks;

namespace Domain.Models.Validations.User
{
    public class UserValidation : AbstractValidator<Entities.User>
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserValidation(IUserService userService,
                              IMapper mapper)
        {
            this._userService = userService;
            _mapper = mapper;
            RuleFor(p => p.Id).NotNull();
            RuleFor(p => p.UserName).NotNull();
            RuleFor(p => p.PasswordHash).NotNull().MinimumLength(6);
            RuleFor(p => p.PhoneNumber).NotNull();
            RuleFor(p => p.Email).EmailAddress(FluentValidation.Validators.EmailValidationMode.AspNetCoreCompatible);
            RuleFor(p => p).MustAsync((p, cancellation) => IsUniqueUserNameAsync(p));

            RuleFor(p => p).NotEmpty().MustAsync((p, cancellation) => IsUniquePhoneNumberAsync(p));

            RuleFor(p => p).MustAsync((p, cancellation) => IsUniqueEmailAsync(p));

            RuleFor(p => p).Must(IsUniqueNationalCodeAsync);

        }
        private async Task<bool> IsUniqueUserNameAsync(Entities.User request)
        {
            Dtos.Requests.Users.UniqueUserValidationRequst _request = new Dtos.Requests.Users.UniqueUserValidationRequst();
            _mapper.Map<Entities.User, Dtos.Requests.Users.UniqueUserValidationRequst>(request, _request);
            return await _userService.isUniqueUserAsync(_request);
        }
        private async Task<bool> IsUniquePhoneNumberAsync(Entities.User request)
        {
            Dtos.Requests.Users.UniquePhoneNumber _request = new Dtos.Requests.Users.UniquePhoneNumber();
            _mapper.Map<Entities.User, Dtos.Requests.Users.UniquePhoneNumber>(request, _request);
            return await _userService.isUniquePhoneNumberAsync(_request);
        }
        private async Task<bool> IsUniqueEmailAsync(Entities.User request)
        {
            Dtos.Requests.Users.UniqueEmailValodationRequest _request = new Dtos.Requests.Users.UniqueEmailValodationRequest();
            _mapper.Map<Entities.User, Dtos.Requests.Users.UniqueEmailValodationRequest>(request, _request);
            return await _userService.isUniqueEmailAsync(_request);
        }
        private bool IsUniqueNationalCodeAsync(Entities.User request)
        {
            return request.NationalId == null || request.NationalId.Length <= 0 || request.NationalId.Length == 10 ? true : false;
        }
    }
}
