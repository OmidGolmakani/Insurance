using Domain.Models.Entities.Fundamentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entities
{
    public class Company : AuditDeleteEntity<long>
    {
        public string Name { get; set; }
        public int InsuranceScore { get; set; }
        public int CustomerScore { get; set; }
    }
}
