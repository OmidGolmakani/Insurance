using Domain.Models.Entities.Fundamentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entities
{
    public class InsurancePoint : AuditDeleteEntity<long>
    {
        public long PointParameterId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int RangeValue { get; set; }
        public InsurancePointParameter InsurancePointParameter { get; set; }

    }
}
