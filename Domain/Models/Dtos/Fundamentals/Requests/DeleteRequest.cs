using System.ComponentModel.DataAnnotations;

namespace  Domain.Models.Dtos.Fundamentals.Requests
{
    public class DeleteRequest<TIdentity> : BaseRequest
    {
        [Required]
        public virtual TIdentity Id { get; set; }
    }
}
