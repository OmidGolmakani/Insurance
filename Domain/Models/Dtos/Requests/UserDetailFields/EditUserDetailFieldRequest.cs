using Domain.Interfaces.Fundamentals.Request;
using Domain.Models.AttributeValidations;
using Domain.Models.Dtos.Fundamentals.Requests;
using Domain.Models.Dtos.Requests.UserDetailFieldLanguageDatas;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Dtos.Requests.UserDetailFields
{
    public class EditUserDetailFieldRequest : EditRequest<long>, IListDataLanguageRequest<long, EditUserDetailFieldLanguageDataRequest>
    {
        [Numeric]
        public long? UserId { get; set; }
        [Required]
        public DataType TypeId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string DisplayName { get; set; }
        [Required]
        public byte Order { get; set; }
        [Required]
        public bool Active { get; set; }
        [Required]
        public bool IsDefault { get; set; }
        public List<EditUserDetailFieldLanguageDataRequest> LanguageDatas { get; set; } = new();
    }
}
