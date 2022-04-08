using Domain.Interfaces.Fundamentals.Request;
using Domain.Models.AttributeValidations;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Dtos.Fundamentals.Requests
{
    public class GetRequest<TIdentity> : BaseRequest,IGetRequest<TIdentity>
        where TIdentity : struct
    {
        [Required]
        [Numeric]
        public virtual TIdentity Id { get; set; }
    }
}
