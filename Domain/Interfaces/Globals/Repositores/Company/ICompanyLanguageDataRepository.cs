using Domain.Interfaces.Fundamentals.Repository;
using Domain.Models.Dtos.Requests.CompanyLanguageDatas;
using Domain.Models.Dtos.Responses.CompanyLanguageDatas;
using Domain.Models.Entities;

namespace Domain.Interfaces.Globals.Repositories
{
    public interface ICompanyLanguageDataRepository : IRepository<long,
                                                                  CompanyLanguageData,
                                                                  GetCompanyLanguageDataRequest,
                                                                  GetCompaniesLanguageDataRequest,
                                                                  CompanyLanguageDataResponse>
    {

    }
}
