using Domain.Interfaces.Fundamentals.Controller;
using Domain.Models.Dtos.Requests.CompanyLanguageDatas;

namespace Domain.Interfaces.Globals.Controllers
{
    public interface ICompanyLanguageDataController : IGetController<GetCompanyLanguageDataRequest, 
                                                                     GetCompaniesLanguageDataRequest>,
                                                      IDeleteController<DeleteCompanyLanguageDataRequest>
    {

    }
}
