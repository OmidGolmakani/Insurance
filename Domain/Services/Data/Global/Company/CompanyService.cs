using AutoMapper;
using Domain.Interfaces.Fundamentals.Repository;
using Domain.Interfaces.Globals.DataServices;
using Domain.Models.Dtos.Requests.Companies;
using Domain.Models.Dtos.Responses.Companies;
using Domain.Models.Entities;
using Domain.Services.Data.Fundamentals;
using FluentValidation;

namespace Domain.Services.Data.Global
{
    public class CompanyService : Service<long,
                                          Company,
                                          GetCompanyRequest,
                                          GetCompaniesRequest,
                                          CompanyResponse,
                                          AddCompanyRequest,
                                          EditCompanyRequest,
                                          DeleteCompanyRequest>, 
        ICompanyService
    {
        public CompanyService(IRepository<long,
                                          Company,
                                          GetCompanyRequest,
                                          GetCompaniesRequest,
                                          CompanyResponse> repository,
            IMapper mapper, IUnitOfWork unitOfWork, IValidator<Company> validator) :
            base(repository, mapper, unitOfWork, validator)
        {
        }
    }
}
