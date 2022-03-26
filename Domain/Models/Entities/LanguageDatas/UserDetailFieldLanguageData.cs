using Domain.Interfaces.Fundamentals.Entity;
using Domain.Models.Entities.Fundamentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entities
{
    public class UserDetailFieldLanguageData : AuditDeleteEntity<long>, ILanguageDataEntity<long>
    {
        public long KeyId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public Language Language { get; set; }
        public UserDetailField UserDetailField { get; set; }
    }
}
