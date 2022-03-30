using AutoMapper;
using Domain.Interfaces.Fundamentals.Repository;
using Domain.Interfaces.Globals.DataServices;
using Domain.Models.Dtos.Requests.InsuranceTitleLanguageDatas;
using Domain.Models.Dtos.Responses.InsuranceTitleLanguageDatas;
using Domain.Models.Entities;
using Domain.Services.Data.Fundamentals;
using FluentValidation;

namespace Domain.Services.Data.Global
{
    public class InsuaranceTitleLanguageDataService : Service<long,
                                                      InsuranceTitleLanguageData,
                                                      GetInsuranceTitleLanguageDataRequest,
                                                      GetInsuranceTitlesLanguageDataRequest,
                                                      InsuranceTitleLanguageDataResponse,
                                                      AddInsuranceTitleLanguageDataRequest,
                                                      EditInsuranceTitleLanguageDataRequest,
                                                      DeleteInsuranceTitleLanguageDataRequest>,
        IInsuranceTitleLanguageDataService
    {
        public InsuaranceTitleLanguageDataService(IRepository<long,
                                                  InsuranceTitleLanguageData,
                                                  GetInsuranceTitleLanguageDataRequest,
                                                  GetInsuranceTitlesLanguageDataRequest,
                                                  InsuranceTitleLanguageDataResponse> repository,
            IMapper mapper, IUnitOfWork unitOfWork, IValidator<InsuranceTitleLanguageData> validator) :
            base(repository, mapper, unitOfWork, validator)
        {
        }
    }
}
