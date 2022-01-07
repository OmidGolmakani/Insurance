using AutoMapper;
using Domain.Interfaces.Globals.DataServices;
using FluentValidation;
using System.Threading.Tasks;

namespace Domain.Models.Validations
{
    public class UserValidation : AbstractValidator<Entities.AspNetUsers>
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserValidation(IUserService userService,
                              IMapper mapper)
        {
            this._userService = userService;
            _mapper = mapper;
            RuleFor(p => p.Id).NotNull().WithMessage("آی دی اجباری می باشد");
            RuleFor(p => p.Name).NotNull().WithMessage("نام اجباری می باشد");
            RuleFor(p => p.Family).NotNull().WithMessage("نام خانوادگی اجباری می باشد");
            RuleFor(p => p.UserName).NotNull().WithMessage("نام کاربری اجباری می باشد");
            RuleFor(p => p.PasswordHash).NotNull().WithMessage("رمز عبور اجباری می باشد")
                                        .MinimumLength(6).WithMessage("رمز عبور باید حداقل 6 کاراکتر باشد");
            RuleFor(p => p.PhoneNumber).NotNull().WithMessage("تلفن همراه اجباری می باشد");
            RuleFor(p => p.Email).EmailAddress(FluentValidation.Validators.EmailValidationMode.AspNetCoreCompatible).WithMessage("آدرس ایمیل غیر مجاز می باشد");
            RuleFor(p => p).MustAsync((p, cancellation) => IsUniqueUserNameAsync(p)).WithMessage("نام کاربری تکراری می باشد");

            RuleFor(p => p).NotEmpty().MustAsync((p, cancellation) => IsUniquePhoneNumberAsync(p)).WithMessage("تلغن همراه تکراری می باشد");

            RuleFor(p => p).MustAsync((p, cancellation) => IsUniqueEmailAsync(p)).WithMessage("پست الکترونیک تکراری می باشد");

            RuleFor(p => p).Must(IsUniqueNationalCodeAsync).WithMessage("کد ملی غیر مجاز می باشد");

        }
        private async Task<bool> IsUniqueUserNameAsync(Entities.AspNetUsers request)
        {
            Dtos.Requests.Users.UniqueUserValidationRequst _request = new Dtos.Requests.Users.UniqueUserValidationRequst();
            _mapper.Map<Entities.AspNetUsers, Dtos.Requests.Users.UniqueUserValidationRequst>(request, _request);
            return await _userService.isUniqueUserAsync(_request);
        }
        private async Task<bool> IsUniquePhoneNumberAsync(Entities.AspNetUsers request)
        {
            Dtos.Requests.Users.UniquePhoneNumber _request = new Dtos.Requests.Users.UniquePhoneNumber();
            _mapper.Map<Entities.AspNetUsers, Dtos.Requests.Users.UniquePhoneNumber>(request, _request);
            return await _userService.isUniquePhoneNumberAsync(_request);
        }
        private async Task<bool> IsUniqueEmailAsync(Entities.AspNetUsers request)
        {
            Dtos.Requests.Users.UniqueEmailValodationRequest _request = new Dtos.Requests.Users.UniqueEmailValodationRequest();
            _mapper.Map<Entities.AspNetUsers, Dtos.Requests.Users.UniqueEmailValodationRequest>(request, _request);
            return await _userService.isUniqueEmailAsync(_request);
        }
        private bool IsUniqueNationalCodeAsync(Entities.AspNetUsers request)
        {
            return request.NationalCode == null || request.NationalCode.Length <= 0 || request.NationalCode.Length == 10 ? true : false;
        }
    }
}
