using Domain.Interfaces.Fundamentals.DataService;
using Domain.Models.Dtos.Requests.CompanyLanguageDatas;
using Domain.Models.Dtos.Responses.CompanyLanguageDatas;
using Domain.Models.Entities;

namespace Domain.Interfaces.Globals.DataServices
{
    public interface ICompanyLanguageDataService : IService<long,
                                                            CompanyLanguageData,
                                                            AddCompanyLanguageDataRequest,
                                                            EditCompanyLanguageDataRequest,
                                                            DeleteCompanyLanguageDataRequest,
                                                            GetCompanyLanguageDataRequest,
                                                            GetCompaniesLanguageDataRequest,
                                                            CompanyLanguageDataResponse>
    {

    }
}
