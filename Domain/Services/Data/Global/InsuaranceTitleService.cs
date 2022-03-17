using AutoMapper;
using Domain.Interfaces.Fundamentals.Repository;
using Domain.Interfaces.Globals.DataServices;
using Domain.Interfaces.Globals.Repositores;
using Domain.Models.Dtos.Fundamentals.Response;
using Domain.Models.Dtos.Requests.InsuranceTitles;
using Domain.Models.Dtos.Responses.InsuranceTitles;
using Domain.Models.Entities;
using Domain.Models.Validations.InsuranceTitle;
using FluentValidation;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Services.Data.Global
{
    public class InsuaranceTitleService : IInsuranceTitleService
    {
        private readonly IInsuranceTitleRepository _insuranceTitleRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public InsuaranceTitleService(IInsuranceTitleRepository insuranceTitleRepository,
                                      IMapper mapper,
                                      IUnitOfWork unitOfWork)
        {
            this._insuranceTitleRepository = insuranceTitleRepository;
            this._mapper = mapper;
            this._unitOfWork = unitOfWork;
        }
        public async Task<InsuranceTitleResponse> Add(AddInsuranceTitleRequest request)
        {
            var entity = _mapper.Map<AddInsuranceTitleRequest, InsuranceTitle>(request);
            InsuranceTitleValidation validator = new InsuranceTitleValidation(this);
            await validator.ValidateAndThrowAsync(entity);
            entity = _insuranceTitleRepository.Add(entity);
            await _unitOfWork.CommitAsync();
            var resopnse = _mapper.Map<InsuranceTitleResponse>
                (entity);
            return resopnse;
        }

        public async Task BatchDelete(IEnumerable<DeleteInsuranceTitleRequest> request)
        {
            _insuranceTitleRepository.DeleteBatch(_mapper.Map<IEnumerable<DeleteInsuranceTitleRequest>, IEnumerable<InsuranceTitle>>(request));
            await _unitOfWork.CommitAsync();
        }

        public async Task BatchUpdate(IEnumerable<EditInsuranceTitleRequest> request)
        {

            foreach (var _request in request)
            {
                InsuranceTitle entity = new();
                entity = _mapper.Map<EditInsuranceTitleRequest, InsuranceTitle>(_request);
                InsuranceTitleValidation validator = new InsuranceTitleValidation(this);
                await validator.ValidateAndThrowAsync(entity);
                _insuranceTitleRepository.Update(entity);
            }
            await _unitOfWork.CommitAsync();
        }

        public async Task<int> CountAsync(GetInsuranceTitlesRequest request, bool includeDeleted = false)
        {
            return await _insuranceTitleRepository.CountAsync
                (_mapper.Map<GetInsuranceTitlesRequest>(request));
        }

        public async Task Delete(DeleteInsuranceTitleRequest request)
        {
            _insuranceTitleRepository.Delete(_mapper.Map<DeleteInsuranceTitleRequest, InsuranceTitle>(request));
            await _unitOfWork.CommitAsync();
        }

        public async Task<InsuranceTitleResponse> GetAsync(GetInsuranceTitleRequest request, bool includeDeleted = false)
        {
            var response = _mapper.Map<InsuranceTitleResponse>(await _insuranceTitleRepository.GetById(request, includeDeleted));
            return await Task.Run(() => response);
        }

        public async Task<ListResponse<InsuranceTitleResponse>> GetsAsync(GetInsuranceTitlesRequest request, bool includeDeleted = false)
        {
            var response = _mapper.Map<IEnumerable<InsuranceTitleResponse>>(await _insuranceTitleRepository.Get(request, includeDeleted));
            return await Task.Run(() => new ListResponse<InsuranceTitleResponse>() { Items = response, Total = response.Count() });
        }

        public async Task<InsuranceTitleResponse> Update(EditInsuranceTitleRequest request)
        {
            InsuranceTitle entity = new();
            entity = _mapper.Map<EditInsuranceTitleRequest, InsuranceTitle>(request);
            InsuranceTitleValidation validator = new InsuranceTitleValidation(this);
            await validator.ValidateAndThrowAsync(entity);
            _insuranceTitleRepository.Update(entity);
            await _unitOfWork.CommitAsync();
            var response = _mapper.Map<InsuranceTitleResponse>(_insuranceTitleRepository.Update(entity));
            return response;
        }
    }
}
