using Domain.Interfaces.Fundamentals.Repository;
using Domain.Models.Dtos.Requests.Companies;
using Domain.Models.Dtos.Responses.Companies;
using Domain.Models.Entities;

namespace Domain.Interfaces.Globals.Repositories
{
    public interface ICompanyRepository : IRepository<long,
                                                      Company,
                                                      GetCompanyRequest,
                                                      GetCompaniesRequest,
                                                      CompanyResponse>
    {

    }
}
