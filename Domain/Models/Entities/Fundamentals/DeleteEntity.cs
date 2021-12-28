using Domain.Interfaces.Fundamentals.Entity;
using System;

namespace Domain.Models.Entities.Fundamentals
{
    public abstract class DeleteEntity : IDeleteEntity
    {
        public virtual bool IsDeleted { get; set; }
        public virtual DateTime? DeletedDate { get; set; }
        public virtual string DeletedBy { get; set; }
    }
}
