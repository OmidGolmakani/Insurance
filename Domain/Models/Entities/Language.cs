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
        public ICollection<CompanyLanguageData> CompanyLanguageDatas { get; set; }
        public ICollection<InsuranceTitleLanguageData> InsuranceTitleLanguageDatas { get; set; }
        public ICollection<PersonLanguageData> PersonLanguageDatas { get; set; }
        public ICollection<PointParameterLanguageData> PointParameterLanguageDatas { get; set; }
        public ICollection<UserDetailLanguageData> UserDetailLanguageDatas { get; set; }
        public ICollection<UserDetailFieldLanguageData> UserDetailFieldLanguageDatas { get; set; }
        public ICollection<UserDetailLookupFieldLanguageData> UserDetailLookupFieldLanguageDatas { get; set; }

    }
}
