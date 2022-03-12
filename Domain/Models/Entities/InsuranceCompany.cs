using Domain.Models.Entities.Fundamentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entities
{
    public class InsuranceCompany : AuditDeleteEntity<long>
    {
        public string Name { get; set; }
        public ICollection<InsurancePointParameter> InsurancePoints { get; set; }
    }
}
