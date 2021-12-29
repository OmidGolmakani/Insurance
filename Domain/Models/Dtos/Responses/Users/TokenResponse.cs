using Domain.Models.Dtos.Fundamentals.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Models.Dtos.Responses.Users
{
    public class TokenResponse : BaseResponse<long>
    {
        [JsonIgnore]
        public override long Id { get => base.Id; set => base.Id = value; }
        public string Value { get; set; }
    }
}
