using Domain.Interfaces.Fundamentals.Controller;
using Domain.Models.Dtos.Requests.Companies;

namespace Domain.Interfaces.Globals.Controllers
{
    public interface ICompanyController : IController<AddCompanyRequest, EditCompanyRequest, DeleteCompanyRequest>,
                                          IGetController<GetCompanyRequest, GetCompaniesRequest>
    {
    }
}
