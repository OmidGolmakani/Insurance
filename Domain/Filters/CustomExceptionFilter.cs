using Domain.CustomException;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Domain.Filters
{
    public class CustomExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            context.Result = ErrorHandle(context);
            context.ExceptionHandled = true;
            base.OnException(context);
        }
        private IActionResult ErrorHandle(ExceptionContext context)
        {
            CustomException.CustomException exception = new CustomException.CustomException();

            if (context.Exception.GetType() == typeof(CustomException.CustomException))
            {
                if (((CustomException.CustomException)context.Exception).Error.Code <= 0)
                {
                    exception = new CustomException.CustomException("خطای ناشناخته");
                }
                else
                {
                    exception = (CustomException.CustomException)context.Exception;
                }
            }
            else if (context.Exception.GetType() == typeof(FluentValidation.ValidationException))
            {
                exception = new CustomException.CustomException(400, context.Exception.Message);

            }
            else
            {

                exception = new CustomException.CustomException(context.Exception.Message, (CustomException.CustomException)context.Exception.InnerException);
            }

            if (exception.Error != null && string.IsNullOrEmpty(exception.Error.Description) == false)
            {
                context.Result = new ObjectResult(exception.Error.Description)
                {
                    StatusCode = exception.Error.Code,
                    Value = exception.Error.Description
                };
            }
            else
            {
                context.Result = new ObjectResult(exception.Message)
                {
                    StatusCode = exception.HResult,
                    Value = exception.Message
                };
            }
            return context.Result;
        }
    }
}
