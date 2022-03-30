using AutoMapper;
using Domain.Data.DbContext;
using Domain.Interfaces.Globals.Repositories;
using Domain.Models.Dtos.Requests.InsuranceTitleLanguageDatas;
using Domain.Models.Dtos.Responses.InsuranceTitleLanguageDatas;
using Domain.Models.Entities;
using Domain.Repositories.Fundamentals;
using Microsoft.AspNetCore.Http;

namespace Domain.Repositories
{
    public class InsuranceTitleLanguageDataRepository : Repository<long, 
                                                                   InsuranceTitleLanguageData, 
                                                                   GetInsuranceTitleLanguageDataRequest, 
                                                                   GetInsuranceTitlesLanguageDataRequest, 
                                                                   InsuranceTitleLanguageDataResponse>, 
                                                                   IInsuranceTitleLanguageDataRepository
    {
        public InsuranceTitleLanguageDataRepository(DbFactory dbFactory,
                                                    IMapper mapper,
                                                    IHttpContextAccessor httpContext)
            : base(dbFactory, mapper, httpContext)
        {
        }
    }
}
