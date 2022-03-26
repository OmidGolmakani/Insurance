using AutoMapper;
using Domain.Interfaces.Fundamentals.DataService;
using Domain.Interfaces.Fundamentals.Entity;
using Domain.Interfaces.Fundamentals.Repository;
using Domain.Models.Dtos.Fundamentals.Response;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using Domain.Interfaces.Fundamentals.Request;

namespace Domain.Services.Data.Fundamentals
{
    public class Service<TIdentity,
                         TEntity,
                         TGetRequest,
                         TGetsRequest,
                         TResponse,
                         TAddRequest,
                         TEditRequest,
                         TDeleteRequest> :
        IService<TIdentity, TEntity, TAddRequest, TEditRequest, TDeleteRequest, TGetRequest, TGetsRequest, TResponse>
        where TEntity : class, IAuditEntity<TIdentity>, IDeleteEntity
        where TAddRequest : class
        where TEditRequest : class
        where TDeleteRequest : class
        where TGetRequest : class, IGetRequest<TIdentity>
        where TGetsRequest : class, IGetsRequest
        where TResponse : class
        where TIdentity : struct
    {
        private readonly IRepository<TIdentity, TEntity, TGetRequest, TGetsRequest, TResponse> _repository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<TEntity> _validator;

        public Service(IRepository<TIdentity, TEntity, TGetRequest, TGetsRequest, TResponse> repository,
                       IMapper mapper,
                       IUnitOfWork unitOfWork,
                       IValidator<TEntity> validator)
        {
            this._repository = repository;
            this._mapper = mapper;
            this._unitOfWork = unitOfWork;
            this._validator = validator;
        }
        public async virtual Task<TResponse> Add(TAddRequest request)
        {
            var entity = _mapper.Map<TAddRequest, TEntity>(request);
            await _validator.ValidateAndThrowAsync(entity);
            entity = _repository.Add(entity);
            await _unitOfWork.CommitAsync();
            var resopnse = _mapper.Map<TResponse>
                (entity);
            return resopnse;
        }

        public async virtual Task BatchDelete(IEnumerable<TDeleteRequest> request)
        {
            _repository.DeleteBatch(_mapper.Map<IEnumerable<TDeleteRequest>, IEnumerable<TEntity>>(request));
            await _unitOfWork.CommitAsync();
        }

        public async virtual Task BatchUpdate(IEnumerable<TEditRequest> request)
        {
            foreach (var _request in request)
            {
                var entity = _mapper.Map<TEditRequest, TEntity>(_request);
                await _validator.ValidateAndThrowAsync(entity);
                _repository.Update(entity);
            }
            await _unitOfWork.CommitAsync();
        }

        public async Task<int> CountAsync(TGetsRequest request, bool includeDeleted = false)
        {
            return await _repository.CountAsync
              (_mapper.Map<TGetsRequest>(request));
        }

        public async virtual Task Delete(TDeleteRequest request)
        {
            _repository.Delete(_mapper.Map<TDeleteRequest, TEntity>(request));
            await _unitOfWork.CommitAsync();
        }

        public virtual async Task<ListResponse<TResponse>> Get(TGetsRequest request, bool includeDeleted = false)
        {
            var response = _mapper.Map<IEnumerable<TResponse>>(await _repository.Get(request, includeDeleted));
            return await Task.Run(() => new ListResponse<TResponse>() { Items = response, Total = response.Count() });
        }

        public virtual async Task<TResponse> GetById(TGetRequest request, bool includeDeleted = false)
        {
            var response = _mapper.Map<TResponse>(await _repository.GetById(request, includeDeleted));
            return await Task.Run(() => response);
        }



        public async virtual Task<TResponse> Update(TEditRequest request)
        {
            var entity = _mapper.Map<TEditRequest, TEntity>(request);
            await _validator.ValidateAndThrowAsync(entity);
            _repository.Update(entity);
            await _unitOfWork.CommitAsync();
            var response = _mapper.Map<TResponse>(_repository.Update(entity));
            return response;
        }

        async Task<ListResponse<TResponseWithLanguage>> IService<TIdentity, TEntity, TAddRequest, TEditRequest, TDeleteRequest, TGetRequest, TGetsRequest, TResponse>.Get<TForeignKeyType, TResponseWithLanguage, TLanguageResponse>(TGetsRequest request, bool includeDeleted)
        {
            var response = _mapper.Map<IEnumerable<TResponseWithLanguage>>(await _repository.Get<TForeignKeyType, TResponseWithLanguage, TLanguageResponse>(request, includeDeleted));
            return await Task.Run(() => new ListResponse<TResponseWithLanguage>() { Items = response, Total = response.Count() });
        }

        async Task<TResponseWithLanguage> IService<TIdentity, TEntity, TAddRequest, TEditRequest, TDeleteRequest, TGetRequest, TGetsRequest, TResponse>.GetById<TForeignKeyType, TResponseWithLanguage, TLanguageResponse>(TGetRequest request, bool includeDeleted)
        {
            var response = _mapper.Map<TResponseWithLanguage>(await _repository.GetById<TForeignKeyType, TResponseWithLanguage, TLanguageResponse>(request, includeDeleted));
            return await Task.Run(() => response);
        }
    }
}
