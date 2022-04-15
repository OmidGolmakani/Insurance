using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CustomException
{
    public class CustomNullReferenceException : NullReferenceException
    {
        public CustomNullReferenceException() { }
        public CustomNullReferenceException(string message) : base(message) { }
        public CustomNullReferenceException(string message, CustomException innerException) : base(message, innerException) { }
        protected CustomNullReferenceException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
