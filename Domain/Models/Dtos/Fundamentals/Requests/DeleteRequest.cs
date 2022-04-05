using System.ComponentModel.DataAnnotations;

namespace  Domain.Models.Dtos.Fundamentals.Requests
{
    public class DeleteRequest<TIdentity> : BaseRequest
    {
        [Required]
        [RegularExpression("(.*[1-9].*)|(.*[.].*[1-9].*)")]
        public virtual TIdentity Id { get; set; }
    }
}
