using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CustomException
{
    public class CustomInvalidOperationException : SystemException
    {
        public CustomInvalidOperationException() { }
        public CustomInvalidOperationException(SerializationInfo info, StreamingContext context) : base(info, context) { }
        public CustomInvalidOperationException(string message) : base(message) { }
        public CustomInvalidOperationException(string message, CustomException innerException) : base(message, innerException) { }

    }
}
