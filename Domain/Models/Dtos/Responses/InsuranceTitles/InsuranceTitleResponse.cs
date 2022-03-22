using Domain.Models.Dtos.Fundamentals.Response;

namespace Domain.Models.Dtos.Responses.InsuranceTitles
{
    public class InsuranceTitleResponse : BaseResponse<int>
    {
        public decimal? Code { get; set; }
        public int? ParentId { get; set; }
        public byte level { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
    }
}
