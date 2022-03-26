using Domain.Models.Entities.Fundamentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entities
{
    public class Company : AuditDeleteEntity<long>
    {
        public long UserId { get; set; }
        public string Name { get; set; }
        public string RegisterCode { get; set; }
        public DateTime RegisterDate { get; set; }
        public User User { get; set; }
        public ICollection<CompanyLanguageData> CompanyLanguageDatas { get; set; }
    }
}
