using Domain.Models.Entities.Fundamentals;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models.Entities
{
    public class Language : AuditDeleteEntity<int>
    {
        public string LanguageName { get; set; }
        public byte Direction { get; set; }
        public string AcceptLanguage { get; set; }
        public bool Active { get; set; }
        public ICollection<User> User { get; set; }

    }
}
