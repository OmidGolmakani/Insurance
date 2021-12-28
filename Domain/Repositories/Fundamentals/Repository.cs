using AutoMapper;
using Domain.Data.DbContext;
using Domain.Interfaces.Fundamentals.Entity;
using Domain.Interfaces.Fundamentals.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Domain.Repositories.Fundamentals
{
    public class Repository<TIdentity, TEntity> : IRepository<TIdentity, TEntity>
        where TIdentity : struct
        where TEntity : class, IAuditEntity<TIdentity>, IDeleteEntity
    {
        private readonly DbFactory _dbFactory;
        private readonly IMapper _mapper;
        private DbSet<TEntity> _dbSet;
        protected DbSet<TEntity> DbSet
        {
            get => _dbSet ?? (_dbSet = _dbFactory.DbContext.Set<TEntity>());
        }
        public Repository(DbFactory dbFactory,
                          IMapper mapper)
        {
            _dbFactory = dbFactory;
            this._mapper = mapper;
        }
        public Repository(DbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }
        public virtual TEntity Add(TEntity entity)
        {
            entity.CreatedDate = DateTime.Now;
            return DbSet.Add(entity).Entity;
        }
        public virtual TEntity Delete(TEntity entity)
        {
            entity.IsDeleted = true;
            entity.DeletedDate = DateTime.Now;
            return DbSet.Update(entity).Entity;
        }

        public virtual IQueryable<TEntity> List(Expression<Func<TEntity, bool>> expression)
        {
            return DbSet.Where(expression).AsNoTracking();
        }

        public virtual TEntity Update(TEntity entity)
        {
            entity.LastModified = DateTime.Now;
            return DbSet.Update(entity).Entity;
        }

        public virtual void UpdateBatch(System.Collections.Generic.IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                entity.LastModified = DateTime.Now;
            }
            DbSet.UpdateRange(entities);
        }

        public virtual long Count(Expression<Func<TEntity, bool>> expression)
        {
            return DbSet.Where(expression).AsNoTracking().Count();
        }

        public virtual void DeleteBatch(System.Collections.Generic.IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                entity.IsDeleted = true;
                entity.DeletedDate = DateTime.Now;
            }
            DbSet.RemoveRange(entities);
        }
    }
}
