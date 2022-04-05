using AutoMapper;
using Domain.Data.DbContext;
using Domain.Interfaces.Globals.Repositories;
using Domain.Models.Dtos.Requests.CompanyLanguageDatas;
using Domain.Models.Dtos.Responses.CompanyLanguageDatas;
using Domain.Models.Entities;
using Domain.Repositories.Fundamentals;
using Microsoft.AspNetCore.Http;

namespace Domain.Repositories
{
    public class CompanyLanguageDataRepository : Repository<long, 
                                                                   CompanyLanguageData, 
                                                                   GetCompanyLanguageDataRequest, 
                                                                   GetCompaniesLanguageDataRequest, 
                                                                   CompanyLanguageDataResponse>, 
                                                                   ICompanyLanguageDataRepository
    {
        public CompanyLanguageDataRepository(DbFactory dbFactory,
                                             IMapper mapper,
                                             IHttpContextAccessor httpContext)
            : base(dbFactory, mapper, httpContext)
        {
        }
    }
}
