using Domain.Interfaces.Fundamentals.Entity;
using Domain.Models.Dtos.Fundamentals.Response;
using Domain.Models.Validations.Fundamentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Fundamentals.DataService
{
    public interface IService<TIdentity, TEntity, TAddRequest, TEditRequest, TDeleteRequest, TGetRequest, TGetsRequest, TResponse>
        where TIdentity : struct
        where TEntity : class, IAuditEntity<TIdentity>, IDeleteEntity
        where TAddRequest : class
        where TEditRequest : class
        where TDeleteRequest : class
        where TResponse : class
        where TGetRequest : class
        where TGetsRequest : class
    {
        Task<TResponse> Add(TAddRequest request);
        Task<TResponse> Update(TEditRequest request);
        Task Delete(TDeleteRequest request);
        Task BatchUpdate(IEnumerable<TEditRequest> request);
        Task BatchDelete(IEnumerable<TDeleteRequest> request);
        Task<TResponse> GetById(TGetRequest request, bool includeDeleted = false);
        Task<ListResponse<TResponse>> Get(TGetsRequest request, bool includeDeleted = false);
        Task<int> CountAsync(TGetsRequest request, bool includeDeleted = false);
    }
}
