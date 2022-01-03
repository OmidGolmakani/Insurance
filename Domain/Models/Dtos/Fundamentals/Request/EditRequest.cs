namespace  Domain.Models.Dtos.Fundamentals.Requests
{
    public class EditRequest<TIdentity> : BaseRequest
    {
        public virtual TIdentity Id { get; set; }
    }
}
