namespace Domain.Models.Dtos.Fundamentals.Requests
{
    public class SQLParameterRequest : BaseRequest
    {
        public string Name { get; set; }
        public string Condition { get; set; }
        public object value { get; set; }
        public string Seprator { get; set; }
    }
}
