namespace Domain.Models.Dtos.Fundamentals.Requests
{
    public class GetRequest<TIdentity> : BaseRequest, Interfaces.Fundamentals.Dto.IGetDto<TIdentity>
        where TIdentity : struct
    {
        public virtual TIdentity Id { get; set; }
    }
}
