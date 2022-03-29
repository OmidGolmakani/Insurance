namespace Domain.Interfaces.Fundamentals.Request
{
    public interface IPageRequest
    {
        int PageIndex { get; set; }
        int PageSize { get; set; }
    }
}
