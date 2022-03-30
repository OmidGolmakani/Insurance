using Domain.Interfaces.Fundamentals.Repository;
using Domain.Models.Dtos.Requests.InsuranceTitleLanguageDatas;
using Domain.Models.Dtos.Responses.InsuranceTitleLanguageDatas;
using Domain.Models.Entities;

namespace Domain.Interfaces.Globals.Repositories
{
    public interface IInsuranceTitleLanguageDataRepository : IRepository<long,
                                                                         InsuranceTitleLanguageData,
                                                                         GetInsuranceTitleLanguageDataRequest,
                                                                         GetInsuranceTitlesLanguageDataRequest,
                                                                         InsuranceTitleLanguageDataResponse>
    {

    }
}
