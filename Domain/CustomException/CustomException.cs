using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CustomException
{
    [Serializable]
    public class CustomException : Exception
    {
        public CustomException()
        { Error = new ErrorResponse(); }
        public CustomException(int code, string message) :
            base(message)
        {
            Error.Code = code;
            Error.Description = message;
        }
        public CustomException(System.Net.HttpStatusCode status, string message) : base(message)
        {
            Error.Code = (int)status;
            Error.Description = message;
        }
        public CustomException(string message)
            : base(message)
        {
            this.Error.Code = 0;
            this.Error.Description = message;
        }

        public CustomException(string message, CustomException innerException)
            : base(message, innerException)
        {
            this.Error.Code = 0;
            this.Error.Description = message;
        }
        public ErrorResponse Error { get; set; } = new ErrorResponse();
    }
}
