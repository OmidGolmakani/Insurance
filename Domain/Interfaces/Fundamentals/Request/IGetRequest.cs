namespace Domain.Interfaces.Fundamentals.Request
{
    public interface IGetRequest<TIdentity> where TIdentity : struct
    {
        public TIdentity Id { get; set; }
    }
}
