using AutoMapper;
using Dapper;
using Domain.Interfaces.Fundamentals.Entity;
using Domain.Interfaces.Fundamentals.Repository;
using Domain.Models.Dtos.Fundamentals.Requests;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories.Fundamentals
{
    public class GetRepository<TIdentity, TEntity, TGetRequest, TGetsRequest, TResponse> : IGetRepository<TGetRequest, TGetsRequest, TResponse>
        where TIdentity : struct
        where TEntity : class, IAuditEntity<TIdentity>, IDeleteEntity
        where TGetRequest : class, Interfaces.Fundamentals.Dto.IGetDto<TIdentity>
        where TGetsRequest : class
        where TResponse : class
    {
        private readonly IMapper _mapper;
        private readonly IDbConnection _dbConnection;

        public GetRepository(IMapper mapper,
                             IDbConnection dbConnection)
        {
            this._mapper = mapper;
            this._dbConnection = dbConnection;
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
            return _dbConnection.QueryFirstOrDefaultAsync<TResponse>($"SELECT * FROM {typeof(TEntity).Name} WHERE {request.Id.GetType().Name}={request.Id}");
        }

        public virtual Task<IEnumerable<TResponse>> Get(TGetsRequest request, bool includeDeleted = false)
        {
            return _dbConnection.QueryAsync<TResponse>(Query(request, includeDeleted));
        }

        public Task<int> Count(TGetsRequest request, bool includeDeleted = false)
        {
            return _dbConnection.ExecuteScalarAsync<int>(Query(request, includeDeleted));
        }
    }
}
