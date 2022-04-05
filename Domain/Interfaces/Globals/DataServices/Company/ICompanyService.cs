using Domain.Interfaces.Fundamentals.DataService;
using Domain.Models.Dtos.Requests.Companies;
using Domain.Models.Dtos.Requests.People;
using Domain.Models.Dtos.Responses.Companies;
using Domain.Models.Dtos.Responses.People;
using Domain.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Globals.DataServices
{
    public interface ICompanyService : IService<long,
                                                Company,
                                                AddCompanyRequest,
                                                EditCompanyRequest,
                                                DeleteCompanyRequest,
                                                GetCompanyRequest,
                                                GetCompaniesRequest,
                                                CompanyResponse>
    {
    }
}
