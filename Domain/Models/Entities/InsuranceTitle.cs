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
        public decimal? Code { get; set; }
        public int? ParentId { get; set; }
        public byte level { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public InsuranceTitle Insurance { get; set; }
        public ICollection<InsuranceTitle> Insurances { get; set; }
        public ICollection<InsuranceTitleLanguageData> InsuranceTitleLanguageDatas { get; set; }

    }
}
