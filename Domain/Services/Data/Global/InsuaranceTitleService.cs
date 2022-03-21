using AutoMapper;
using Domain.Interfaces.Fundamentals.Repository;
using Domain.Interfaces.Globals.DataServices;
using Domain.Models.Dtos.Requests.InsuranceTitles;
using Domain.Models.Dtos.Responses.InsuranceTitles;
using Domain.Models.Entities;
using Domain.Services.Data.Fundamentals;
using FluentValidation;

namespace Domain.Services.Data.Global
{
    public class InsuaranceTitleService : Service<int,
                                                  InsuranceTitle,
                                                  GetInsuranceTitleRequest,
                                                  GetInsuranceTitlesRequest,
                                                  InsuranceTitleResponse,
                                                  AddInsuranceTitleRequest,
                                                  EditInsuranceTitleRequest,
                                                  DeleteInsuranceTitleRequest>, IInsuranceTitleService
    {
        public InsuaranceTitleService(IRepository<int, InsuranceTitle, GetInsuranceTitleRequest, GetInsuranceTitlesRequest, InsuranceTitleResponse> repository, IMapper mapper, IUnitOfWork unitOfWork, IValidator<InsuranceTitle> validator) : base(repository, mapper, unitOfWork, validator)
        {
        }
    }
}
