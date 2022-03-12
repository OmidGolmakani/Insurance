using Domain.Models.Entities.Fundamentals;
using System.Collections.Generic;

namespace Domain.Models.Entities
{
    public class UserDetailLookupField : AuditDeleteEntity<long>
    {
        public long FieldId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public byte Order { get; set; }
        public bool Active { get; set; }
        public bool IsDefault { get; set; }
        public UserDetailField Field { get; set; }
        public ICollection<UserDetailField> UserDetailFields { get; set; }
    }
}
