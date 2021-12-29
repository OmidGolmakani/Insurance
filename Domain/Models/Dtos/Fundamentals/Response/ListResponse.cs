using System.Collections.Generic;

namespace  Domain.Models.Dtos.Fundamentals.Response
{
    public class ListResponse<T>
    {
        public virtual IEnumerable<T> Items { get; set; }
        public virtual int Total { get; set; }
    }
}
