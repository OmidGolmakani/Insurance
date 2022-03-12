using Domain.Interfaces.Fundamentals.Entity;
using Domain.Models.Entities.Fundamentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Fundamentals.DataSeeding
{
    public interface ISeeding<TEntity, TIdentityType> where TIdentityType: struct
                                                      where TEntity : AuditDeleteEntity<TIdentityType>
    {
        public List<TEntity> GetSeeding();
    }
}
