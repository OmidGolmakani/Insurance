using Domain.Interfaces.Fundamentals.Entity;
using Domain.Models.Entities.Fundamentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entities
{
    public class UserDetailLookupFieldLanguageData : AuditDeleteEntity<long>, ILanguageDataEntity<long>
    {
        public long KeyId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public Language Language { get; set; }
        public UserDetailLookupField UserDetailLookupField { get; set; }
    }
}
