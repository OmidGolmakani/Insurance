using Domain.Interfaces.Fundamentals.Entity;
using Domain.Models.Entities.Fundamentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entities
{
    public class InsuranceTitleLanguageData : AuditDeleteEntity<long>, ILanguageDataEntity<int>
    {
        public int KeyId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Language Language { get; set; }
        public InsuranceTitle InsuranceTitle { get; set; }
    }
}
