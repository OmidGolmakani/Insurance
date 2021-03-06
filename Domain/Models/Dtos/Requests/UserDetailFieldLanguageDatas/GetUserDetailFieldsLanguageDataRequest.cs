using Domain.Interfaces.Fundamentals.Request;
using Domain.Models.Dtos.Fundamentals.Requests;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Dtos.Requests.UserDetailFieldLanguageDatas
{
    public class GetUserDetailFieldsLanguageDataRequest : GetsRequest, IGetsLanguageDataRequest<long>
    {
        public long? KeyId { get; set; }
        public int? LanguageId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
