using Domain.Models.Entities.Fundamentals;
using System.Collections.Generic;

namespace Domain.Models.Entities
{
    public class UserDetailField : AuditDeleteEntity<long>
    {
        public long? UserId { get; set; }
        public byte TypeId { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public byte Order { get; set; }
        public bool Active { get; set; }
        public bool IsDefault { get; set; }
        public User User { get; set; }
        public ICollection<UserDetail> UserDetails  { get; set; }
        public ICollection<UserDetailLookupField> UserDetailLookupFields { get; set; }
    }
}
