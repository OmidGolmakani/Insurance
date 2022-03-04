using Domain.Interfaces.Fundamentals.Entity;
using System;

namespace Domain.Models.Entities.Fundamentals
{
    public abstract class AuditDeleteEntity<TIdentity> : DeleteEntity,
        IAuditEntity<TIdentity>
        where TIdentity : struct
    {
        public TIdentity Id { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual DateTime? LastModified { get; set; }
        public virtual string LastModifiedBy { get; set; }
        public virtual int LanguageId { get; set; }
        public virtual Language Language { get; set; }

    }
}
