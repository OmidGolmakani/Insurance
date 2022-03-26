using Domain.Interfaces.Fundamentals.Request;
using Domain.Interfaces.Fundamentals.Response;
using Domain.Models.Dtos.Fundamentals.Requests;
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
        where TGetRequest : class, IGetRequest<TIdentity>
        where TGetsRequest : class,IGetsRequest
        where TResponse : class
    {
        TEntity Add(TEntity entity);
        TEntity Delete(TEntity entity);
        void DeleteBatch(IEnumerable<TEntity> entities);
        TEntity Update(TEntity entity);
        void UpdateBatch(IEnumerable<TEntity> entities);
        Task<TResponse> GetById(TGetRequest request, bool includeDeleted = false);
        Task<TResponseWithLanguage> GetById<TForeignKeyType, TResponseWithLanguage, TLanguageResponse>(TGetRequest request, bool includeDeleted = false)
             where TForeignKeyType : struct
             where TLanguageResponse : class, ILanguageDataResponse<TForeignKeyType>
             where TResponseWithLanguage : IResponseWithLanguageDatas<TForeignKeyType, TLanguageResponse>;
        Task<IEnumerable<TResponse>> Get(TGetsRequest request, bool includeDeleted = false);
        Task<IEnumerable<TResponseWithLanguage>> Get<TForeignKeyType, TResponseWithLanguage, TLanguageResponse>(TGetsRequest request, bool includeDeleted = false)
             where TForeignKeyType : struct
             where TLanguageResponse : class, ILanguageDataResponse<TForeignKeyType>
             where TResponseWithLanguage : IResponseWithLanguageDatas<TForeignKeyType, TLanguageResponse>;
        Task<int> CountAsync(TGetsRequest request, bool includeDeleted = false);
    }
}
