using Domain.Models.Entities.Fundamentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entities
{
    public class InsuranceTitle : AuditDeleteEntity<int>
    {
        public decimal Code { get; set; }
        public byte level { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
