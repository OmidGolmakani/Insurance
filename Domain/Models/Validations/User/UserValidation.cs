using Domain.Models.Validations.Fundamentals;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Domain.Models.Validations.User
{
    public class UserValidation : Validation<long, Entities.User>
    {
        private readonly UserManager<Entities.User> _userManager;

        public UserValidation(UserManager<Entities.User> userManager)
        {
            this._userManager = userManager;
            RuleFor(p => p.Id).NotNull();
            RuleFor(p => p.UserName).NotNull();
            RuleFor(p => p.PasswordHash).NotNull().MinimumLength(6);
            RuleFor(p => p.PhoneNumber).NotNull();
            RuleFor(p => p.PhoneNumberConfirmed).NotEqual(false);
            RuleFor(p=> p.NationalId).NotEqual("0");
            RuleFor(p => p.Email).EmailAddress(FluentValidation.Validators.EmailValidationMode.AspNetCoreCompatible);
            RuleFor(p => p).MustAsync((p, cancellation) => IsUniqueUserNameAsync(p));

            RuleFor(p => p).NotEmpty().MustAsync((p, cancellation) => IsUniquePhoneNumberAsync(p));

            RuleFor(p => p).MustAsync((p, cancellation) => IsUniqueEmailAsync(p));

            RuleFor(p => p).Must(IsUniqueNationalCodeAsync);
        }
        private async Task<bool> IsUniqueUserNameAsync(Entities.User request)
        {
            Dtos.Requests.Users.UniqueUserValidationRequst _request = new Dtos.Requests.Users.UniqueUserValidationRequst();
            //_mapper.Map<Entities.User, Dtos.Requests.Users.UniqueUserValidationRequst>(request, _request);
            //return await _userService.isUniqueUserAsync(_request);
            return true;
        }
        private async Task<bool> IsUniquePhoneNumberAsync(Entities.User request)
        {
            Dtos.Requests.Users.UniquePhoneNumber _request = new Dtos.Requests.Users.UniquePhoneNumber();
            //_mapper.Map<Entities.User, Dtos.Requests.Users.UniquePhoneNumber>(request, _request);
            //return await _userService.isUniquePhoneNumberAsync(_request);
            return true;

        }
        private async Task<bool> IsUniqueEmailAsync(Entities.User request)
        {
            Dtos.Requests.Users.UniqueEmailValodationRequest _request = new Dtos.Requests.Users.UniqueEmailValodationRequest();
            //_mapper.Map<Entities.User, Dtos.Requests.Users.UniqueEmailValodationRequest>(request, _request);
            //return await _userService.isUniqueEmailAsync(_request);
            return true;

        }
        private bool IsUniqueNationalCodeAsync(Entities.User request)
        {
            return request.NationalId == null || request.NationalId.Length <= 0 || request.NationalId.Length == 10 ? true : false;
        }
    }
}
