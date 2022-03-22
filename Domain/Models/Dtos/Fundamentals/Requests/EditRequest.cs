using System.ComponentModel.DataAnnotations;

namespace  Domain.Models.Dtos.Fundamentals.Requests
{
    public class EditRequest<TIdentity> : BaseRequest
    {
        [Required]
        public virtual TIdentity Id { get; set; }
        [Required]
        public virtual int LanguageId { get; set; }
    }
}
