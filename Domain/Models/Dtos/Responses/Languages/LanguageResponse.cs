using Domain.Models.Dtos.Fundamentals.Response;

namespace Domain.Models.Dtos.Responses.Languages
{
    public class LanguageResponse : BaseResponse<int>
    {
        public string LanguageName { get; set; }
        public byte Direction { get; set; }
        public bool Active { get; set; }
    }
}
