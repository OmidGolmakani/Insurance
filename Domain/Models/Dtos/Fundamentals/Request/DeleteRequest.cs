namespace Domain.Dtos.Fundamentals.Request
{
    public class DeleteRequest<TIdentity> : BaseRequest
    {
        public virtual TIdentity Id { get; set; }
    }
}
