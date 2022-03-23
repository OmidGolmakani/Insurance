using System;

namespace Domain.Interfaces.Fundamentals.Entity
{
    public interface IAuditEntity<TIdentityType> where TIdentityType : struct
    {
        public TIdentityType Id { get; set; }
        DateTime CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime? LastModified { get; set; }
        string LastModifiedBy { get; set; }
    }
}
