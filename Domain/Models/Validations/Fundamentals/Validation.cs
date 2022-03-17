using Domain.Interfaces.Fundamentals.Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Validations.Fundamentals
{
    public class Validation<TIdentity, TEntity> : AbstractValidator<TEntity>
        where TIdentity : struct
        where TEntity : class, IAuditEntity<TIdentity>, IDeleteEntity
    {
        public Validation()
        {
            RuleFor(p=> p.LanguageId).NotNull().NotEmpty();
        }
    }
}
