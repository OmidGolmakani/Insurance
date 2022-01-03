namespace  Domain.Models.Dtos.Fundamentals.Requests
{
    public class DeleteRequest<TIdentity> : BaseRequest
    {
        public virtual TIdentity Id { get; set; }
    }
}
