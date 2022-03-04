using Domain.Models.Entities.Fundamentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entities
{
    public class InsurancePointParameter : AuditDeleteEntity<long>
    {
        public long InsuranceId { get; set; }
        public int PointParameterId { get; set; }
        public InsuranceCompany InsuranceCompany { get; set; }
        public PointParameter PointParameter { get; set; }
        public ICollection<InsurancePoint> insurancePoints { get; set; }
    }
}
