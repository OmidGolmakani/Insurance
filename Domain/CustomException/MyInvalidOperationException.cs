using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CustomException
{
    public class MyInvalidOperationException : SystemException
    {
        public MyInvalidOperationException() { }
        public MyInvalidOperationException(SerializationInfo info, StreamingContext context) : base(info, context) { }
        public MyInvalidOperationException(string message) : base(message) { }
        public MyInvalidOperationException(string message, MyException innerException) : base(message, innerException) { }
    }
}
