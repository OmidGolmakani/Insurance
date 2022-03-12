using Domain.Models.Entities.Fundamentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entities
{
    public class UserDetail : AuditDeleteEntity<long>
    {
        public long FieldId { get; set; }
        public string Value { get; set; }
        public UserDetailField UserDetailField { get; set; }
        public ICollection<UserDetailField> UserDetailFields { get; set; }
    }
}
