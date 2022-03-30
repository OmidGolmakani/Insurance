using Domain.Interfaces.Fundamentals.Controller;
using Domain.Models.Dtos.Requests.InsuranceTitleLanguageDatas;

namespace Domain.Interfaces.Globals.Controllers
{
    public interface IInsuranceTitleLanguageDataController : IGetController<GetInsuranceTitleLanguageDataRequest, 
                                                                            GetInsuranceTitlesLanguageDataRequest>,
                                                             IDeleteController<DeleteInsuranceTitleLanguageDataRequest>
    {

    }
}
