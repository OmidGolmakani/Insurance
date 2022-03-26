using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Fundamentals.Request
{
    public interface IGetRequest<TIdentity> where TIdentity : struct
    {
        public TIdentity Id { get; set; }
    }
}
