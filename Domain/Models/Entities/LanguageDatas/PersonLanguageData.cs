using Domain.Interfaces.Fundamentals.Entity;
using Domain.Models.Entities.Fundamentals;
using System.Collections.Generic;

namespace Domain.Models.Entities
{
    public class PersonLanguageData : AuditDeleteEntity<long>, ILanguageDataEntity<long>
    {
        public long KeyId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public Language Language { get; set; }
        public Person Person { get; set; }
    }
}
