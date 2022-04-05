using Domain.Interfaces.Fundamentals.DataService;
using Domain.Models.Dtos.Requests.InsuranceTitleLanguageDatas;
using Domain.Models.Dtos.Responses.InsuranceTitleLanguageDatas;
using Domain.Models.Entities;

namespace Domain.Interfaces.Globals.DataServices
{
    public interface IInsuranceTitleLanguageDataService : IService<long,
                                                          InsuranceTitleLanguageData,
                                                          AddInsuranceTitleLanguageDataRequest,
                                                          EditInsuranceTitleLanguageDataRequest,
                                                          DeleteInsuranceTitleLanguageDataRequest,
                                                          GetInsuranceTitleLanguageDataRequest,
                                                          GetInsuranceTitlesLanguageDataRequest,
                                                          InsuranceTitleLanguageDataResponse>
    {

    }
}
