using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CustomException
{
    [Serializable]
    public class MyException : Exception
    {
        public MyException()
        { Error = new ErrorResponse(); }
        public MyException(int code, string message) :
            base(message)
        {
            Error.Code = code;
            Error.Description = message;
        }
        public MyException(System.Net.HttpStatusCode status, string message) : base(message)
        {
            Error.Code = (int)status;
            Error.Description = message;
        }
        public MyException(string message)
            : base(message)
        {
            this.Error.Code = 0;
            this.Error.Description = message;
        }

        public MyException(string message, Exception innerException)
            : base(message, innerException)
        {
            this.Error.Code = 0;
            this.Error.Description = message;
        }
        public ErrorResponse Error { get; set; } = new ErrorResponse();
    }
}
