using AutoMapper;
using Dapper;
using Domain.Data.DbContext;
using Domain.Interfaces.Fundamentals.Dto;
using Domain.Interfaces.Fundamentals.Entity;
using Domain.Interfaces.Fundamentals.Repository;
using Domain.Models.Dtos.Fundamentals.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Domain.Repositories.Fundamentals
{
    public class Repository<TIdentity, TEntity, TGetRequest, TGetsRequest, TResponse> : IRepository<TIdentity, TEntity, TGetRequest, TGetsRequest, TResponse>
        where TIdentity : struct
        where TEntity : class, IAuditEntity<TIdentity>, IDeleteEntity
        where TGetRequest : class, IGetDto<TIdentity>
        where TGetsRequest : class
        where TResponse : class
    {
        private readonly DbFactory _dbFactory;
        private readonly IMapper _mapper;
        private SqlConnection _dbConnection;
        private DbSet<TEntity> _dbSet;
        protected DbSet<TEntity> DbSet
        {
            get => _dbSet ?? (_dbSet = _dbFactory.DbContext.Set<TEntity>());
        }
        protected SqlConnection DbConnection
        {
            get => _dbConnection ?? (_dbConnection = _dbFactory.DbConnection);
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
        private string Query(TGetsRequest request, bool includeDeleted = false)
        {
            string q = $"SELECT * FROM {typeof(TEntity).Name}";
            var Propertes = request.GetType().GetProperties();
            string where = "";
            if (request != null)
            {
                foreach (var property in Propertes)
                {
                    var parameter = new SQLParameterRequest();
                    parameter.Name = property.Name;
                    switch (Type.GetTypeCode(property.PropertyType))
                    {
                        case TypeCode.String:
                            if (string.IsNullOrEmpty(property.GetValue(request).ToString()) == false)
                            {
                                parameter.Condition = "LIKE";
                                parameter.value = $"%{property.GetValue(request).ToString()}%";
                                parameter.Seprator = "AND";
                            }
                            break;
                        case TypeCode.Byte:
                        case TypeCode.Int16:
                        case TypeCode.Int32:
                        case TypeCode.Int64:
                        case TypeCode.Double:
                        case TypeCode.Decimal:
                            parameter.Condition = "=";
                            parameter.value = property.GetValue(request).ToString();
                            parameter.Seprator = "AND";
                            break;
                        case TypeCode.Boolean:
                            parameter.Condition = "=";
                            parameter.value = property.GetValue(request).ToString();
                            parameter.Seprator = "AND";
                            break;
                        case TypeCode.DateTime:
                            break;
                        default:
                            parameter = null;
                            break;
                    }
                    where = where.Trim().Length == 0 && parameter != null ? where = "WHERE" : where = where + "";
                    if (parameter != null && property == Propertes.LastOrDefault()) parameter.Seprator = "";
                    where = where.Trim().Length != 0 && parameter != null ? where = $" {parameter.Name} {parameter.value} {parameter.Seprator}" : where = where + "";
                }
            }
            return q + where;
        }

        public virtual Task<TResponse> GetById(TGetRequest request, bool includeDeleted = false)
        {
            return DbConnection.QueryFirstOrDefaultAsync<TResponse>($"SELECT * FROM {typeof(TEntity).Name} WHERE {nameof(request.Id)}={request.Id}");
        }

        public virtual Task<IEnumerable<TResponse>> Get(TGetsRequest request, bool includeDeleted = false)
        {
            return DbConnection.QueryAsync<TResponse>(Query(request, includeDeleted));
        }

        public Task<int> Count(TGetsRequest request, bool includeDeleted = false)
        {
            return DbConnection.ExecuteScalarAsync<int>(Query(request, includeDeleted));
        }
    }
}
