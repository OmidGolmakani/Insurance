
namespace Domain.Models.Dtos.Fundamentals.Requests
{
    public class PageRequest 
    {
        int _pageSize = 0;
        public virtual int PageSize
        {
            set
            {
                this._pageSize = value;
            }
            get
            {
                return this._pageSize > 0 ?
                    this._pageSize :
                    int.MaxValue;

            }
        }
        public virtual int PageIndex { get; set; } = 0;
    }
}
