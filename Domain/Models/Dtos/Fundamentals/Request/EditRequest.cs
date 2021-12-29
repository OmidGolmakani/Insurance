namespace  Domain.Models.Dtos.Fundamentals.Request
{
    public class EditRequest<TIdentity> : BaseRequest
    {
        public virtual TIdentity Id { get; set; }
    }
}
