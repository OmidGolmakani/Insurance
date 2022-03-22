using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Dtos.Fundamentals.Requests
{
    public class AddRequest : BaseRequest
    {
        [Required]
        public virtual int LanguageId { get; set; }
    }
}
