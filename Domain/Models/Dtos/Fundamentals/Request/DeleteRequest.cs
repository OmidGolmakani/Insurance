namespace  Domain.Models.Dtos.Fundamentals.Request
{
    public class DeleteRequest<TIdentity> : BaseRequest
    {
        public virtual TIdentity Id { get; set; }
    }
}
