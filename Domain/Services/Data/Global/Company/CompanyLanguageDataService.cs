using AutoMapper;
using Domain.Interfaces.Fundamentals.Repository;
using Domain.Interfaces.Globals.DataServices;
using Domain.Models.Dtos.Requests.CompanyLanguageDatas;
using Domain.Models.Dtos.Responses.CompanyLanguageDatas;
using Domain.Models.Entities;
using Domain.Services.Data.Fundamentals;
using FluentValidation;

namespace Domain.Services.Data.Global
{
    public class CompanyLanguageDataService : Service<long,
                                                      CompanyLanguageData,
                                                      GetCompanyLanguageDataRequest,
                                                      GetCompaniesLanguageDataRequest,
                                                      CompanyLanguageDataResponse,
                                                      AddCompanyLanguageDataRequest,
                                                      EditCompanyLanguageDataRequest,
                                                      DeleteCompanyLanguageDataRequest>,
        ICompanyLanguageDataService
    {
        public CompanyLanguageDataService(IRepository<long,
                                                      CompanyLanguageData,
                                                      GetCompanyLanguageDataRequest,
                                                      GetCompaniesLanguageDataRequest,
                                                      CompanyLanguageDataResponse> repository,
            IMapper mapper, IUnitOfWork unitOfWork, IValidator<CompanyLanguageData> validator) :
            base(repository, mapper, unitOfWork, validator)
        {
        }
    }
}
