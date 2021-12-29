namespace  Domain.Models.Dtos.Fundamentals.Request
{
    public class GetRequest<TIdentity> : BaseRequest
    {
        public virtual TIdentity Id { get; set; }
    }
}
