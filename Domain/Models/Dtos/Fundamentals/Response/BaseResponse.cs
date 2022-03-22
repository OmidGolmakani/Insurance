namespace  Domain.Models.Dtos.Fundamentals.Response
{
    public class BaseResponse<TIdentity>
    {
        public virtual TIdentity Id { get; set; }
        public int LanguageId { get; set; }
        public string AcceptLanguage { get; set; }
    }
}
