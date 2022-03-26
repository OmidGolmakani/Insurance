using Domain.Models.Entities.Fundamentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entities
{
    public class PointParameter : AuditDeleteEntity<int>
    {
        public string Name { get; set; }
        public bool IsRequired { get; set; }
        public bool Active { get; set; }
        public ICollection<PointParameterLanguageData> PointParameterLanguageDatas { get; set; }
        public ICollection<InsurancePointParameter> InsurancePointParameters { get; set; }
    }
}
