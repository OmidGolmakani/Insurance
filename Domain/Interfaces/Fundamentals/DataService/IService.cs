using Domain.Interfaces.Fundamentals.Entity;
using Domain.Interfaces.Fundamentals.Request;
using Domain.Interfaces.Fundamentals.Response;
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
        where TGetRequest : class, IGetRequest<TIdentity>
        where TGetsRequest : class, IGetsRequest
    {
        Task<TResponse> Add(TAddRequest request);
        Task<TResponse> Update(TEditRequest request);
        Task Delete(TDeleteRequest request);
        Task BatchUpdate(IEnumerable<TEditRequest> request);
        Task BatchDelete(IEnumerable<TDeleteRequest> request);
        Task<TResponse> GetById(TGetRequest request, bool includeDeleted = false);
        Task<TResponseWithLanguage> GetById<TForeignKeyType, TResponseWithLanguage, TLanguageResponse>(TGetRequest request, bool includeDeleted = false)
         where TForeignKeyType : struct
         where TLanguageResponse : class, ILanguageDataResponse<TForeignKeyType>
         where TResponseWithLanguage : IResponseWithLanguageDatas<TForeignKeyType, TLanguageResponse>;
        Task<ListResponse<TResponse>> Get(TGetsRequest request, bool includeDeleted = false);
        Task<ListResponse<TResponseWithLanguage>> Get<TForeignKeyType, TResponseWithLanguage, TLanguageResponse>(TGetsRequest request, bool includeDeleted = false)
            where TForeignKeyType : struct
            where TLanguageResponse : class, ILanguageDataResponse<TForeignKeyType>
            where TResponseWithLanguage : class, IResponseWithLanguageDatas<TForeignKeyType, TLanguageResponse>;
        Task<int> CountAsync(TGetsRequest request, bool includeDeleted = false);

    }
}
