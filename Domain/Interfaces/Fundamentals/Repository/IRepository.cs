using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Domain.Interfaces.Fundamentals.Repository
{
    public interface IRepository<TIdentity, TEntity, TGetRequest, TGetsRequest, TResponse>
        where TEntity : class
        where TIdentity : struct
        where TGetRequest : class
        where TGetsRequest : class
        where TResponse : class
    {
        TEntity Add(TEntity entity);
        TEntity Delete(TEntity entity);
        void DeleteBatch(IEnumerable<TEntity> entities);
        TEntity Update(TEntity entity);
        void UpdateBatch(IEnumerable<TEntity> entities);
        Task<TResponse> GetById(TGetRequest request, bool includeDeleted = false);
        Task<IEnumerable<TResponse>> Get(TGetsRequest request, bool includeDeleted = false);
        Task<int> CountAsync(TGetsRequest request, bool includeDeleted = false);
    }
}
