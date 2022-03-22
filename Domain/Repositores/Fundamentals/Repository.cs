﻿using AutoMapper;
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
using Domain.Extensions.Other;
using Microsoft.AspNetCore.Http;
using Microsoft.Net.Http.Headers;

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
        private readonly HttpContext _HttpContext;
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
                          IMapper mapper,
                          Microsoft.AspNetCore.Http.IHttpContextAccessor httpContext)
        {
            _dbFactory = dbFactory;
            this._mapper = mapper;
            this._HttpContext = httpContext.HttpContext;
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
            entity = DbSet.Find(entity.Id);
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
            entity = DbSet.Find(entity.Id);
            entity.LastModified = DateTime.Now;
            return DbSet.Update(entity).Entity;
        }

        public virtual void UpdateBatch(IEnumerable<TEntity> entities)
        {
            entities = DbSet.Where(e => entities.Select(e => e.Id).Contains(e.Id));
            foreach (var entity in entities)
            {
                entity.LastModified = DateTime.Now;
            }
            DbSet.UpdateRange(entities);
        }

        public virtual void DeleteBatch(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                entity.IsDeleted = true;
                entity.DeletedDate = DateTime.Now;
            }
            DbSet.RemoveRange(entities);
        }
        private async Task<string> GetColumns(Type entity)
        {
            Task task1Open = OpenConnectionAsync();
            task1Open.Wait();
            var result = await DbConnection.QueryAsync<string>($"SELECT name FROM sys.all_columns WHERE object_id=OBJECT_ID('V_{entity.Name}')");
            Task taskClose = CloseConnectionAsync();
            taskClose.Wait();
            return result.ToList().ListToString(",");
        }
        private async Task<string> Query(TGetsRequest request, bool includeDeleted = false, bool GetCount = false)
        {
            string q = GetCount == false ? $"SELECT {await GetColumns(typeof(TEntity))} FROM V_{typeof(TEntity).Name}" : $"SELECT COUNT(*) FROM V_{typeof(TEntity).Name}";
            var Propertes = request.GetType().GetProperties();
            string where = "";
            if (request != null)
            {
                foreach (var property in Propertes)
                {
                    var parameter = new SQLParameterRequest();
                    parameter.Name = property.Name;
                    var propertyType = Type.GetTypeCode(property.PropertyType);
                    if (property.PropertyType.IsGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                    {
                        propertyType = Type.GetTypeCode(property.PropertyType.GetGenericArguments()[0]);
                    }
                    switch (propertyType)
                    {
                        case TypeCode.String:
                            if (string.IsNullOrEmpty(property.GetValue(request)?.ToString() ?? "") == false)
                            {
                                parameter.Condition = "LIKE";
                                parameter.value = $"%{property.GetValue(request)}%";
                            }
                            break;
                        case TypeCode.Byte:
                        case TypeCode.Int16:
                        case TypeCode.Int32:
                            parameter.Condition = "=";
                            decimal _outDec = 0;
                            if (decimal.TryParse(property.GetValue(request)?.ToString(), out _outDec))
                            {
                                parameter.value = property.GetValue(request)?.ToString() ?? "";
                            }
                            break;
                        case TypeCode.Int64:
                        case TypeCode.Double:
                        case TypeCode.Decimal:
                            parameter.Condition = "=";
                            long _outInt = 0;
                            if (long.TryParse(property.GetValue(request)?.ToString(), out _outInt))
                            {
                                parameter.value = property.GetValue(request)?.ToString() ?? "";
                            }
                            break;
                        case TypeCode.Boolean:
                            parameter.Condition = "=";
                            bool _outBool = false;
                            if (bool.TryParse(property.GetValue(request)?.ToString(), out _outBool))
                            {
                                parameter.value = property.GetValue(request)?.ToString() ?? "";
                            }
                            break;
                        case TypeCode.DateTime:
                            parameter.Condition = "=";
                            DateTime _outDate = DateTime.Now;
                            if (DateTime.TryParse("", out _outDate))
                            {
                                parameter.value = property.GetValue(request)?.ToString() ?? "";
                            }
                            break;
                        default:
                            parameter = null;
                            break;
                    }
                    if (parameter.value != null && parameter.value.ToString() != "")
                    {
                        where += $"{property.Name} {parameter.Condition} {parameter.value}";
                    }
                    if (property.GetType() != Propertes.LastOrDefault().GetType())
                    {
                        parameter.Seprator = " AND ";
                        where += parameter.Seprator + " ";
                    }
                }
            }
            var Accept_Language = _HttpContext?.Request?.Headers?.FirstOrDefault(h => h.Key == HeaderNames.AcceptLanguage).Value ?? "";

            if (where.Trim().Length == 0)
            {
                return $"{q} WHERE AcceptLanguage ='{Accept_Language.FirstOrDefault()}' AND IsDeleted={Convert.ToByte(includeDeleted)}";
            }
            else
            {
                return $"{q} WHERE AcceptLanguage ='{Accept_Language.FirstOrDefault()}' AND IsDeleted={Convert.ToByte(includeDeleted)} AND {where}";
            }
        }

        public virtual async Task<TResponse> GetById(TGetRequest request, bool includeDeleted = false)
        {
            var Accept_Language = _HttpContext?.Request?.Headers?.FirstOrDefault(h => h.Key == HeaderNames.AcceptLanguage).Value ?? "";
            if (Accept_Language.Count() == 0)
            {
                return await DbConnection.QueryFirstOrDefaultAsync<TResponse>($"SELECT {await GetColumns(typeof(TEntity))} FROM V_{typeof(TEntity).Name} WHERE IsDeleted={Convert.ToByte(includeDeleted)} AND {nameof(request.Id)}={request.Id}");

            }
            else
            {
                return await DbConnection.QueryFirstOrDefaultAsync<TResponse>($"SELECT {await GetColumns(typeof(TEntity))} FROM V_{typeof(TEntity).Name} WHERE IsDeleted={Convert.ToByte(includeDeleted)}  AND AcceptLanguage='{Accept_Language.FirstOrDefault()}' AND {nameof(request.Id)}={request.Id}");
            }
        }

        public async virtual Task<IEnumerable<TResponse>> Get(TGetsRequest request, bool includeDeleted = false)
        {
            return await DbConnection.QueryAsync<TResponse>(await Query(request, includeDeleted));
        }

        public async virtual Task<int> CountAsync(TGetsRequest request, bool includeDeleted = false)
        {
            return await DbConnection.ExecuteScalarAsync<int>(await Query(request, includeDeleted));
        }
        private async Task CloseConnectionAsync()
        {
            if (DbConnection.State != System.Data.ConnectionState.Closed) await DbConnection.CloseAsync();
        }
        private async Task OpenConnectionAsync()
        {
            if (DbConnection.State != System.Data.ConnectionState.Open) await DbConnection.OpenAsync();
        }
    }
}
