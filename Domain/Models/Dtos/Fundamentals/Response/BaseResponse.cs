using System.Text.Json.Serialization;

namespace  Domain.Models.Dtos.Fundamentals.Response
{
    public class BaseResponse<TIdentity>
    {
        [JsonPropertyOrder(1)]
        public virtual TIdentity Id { get; set; }
    }
}
