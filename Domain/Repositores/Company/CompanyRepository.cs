using AutoMapper;
using Domain.Data.DbContext;
using Domain.Interfaces.Globals.Repositories;
using Domain.Models.Dtos.Requests.Companies;
using Domain.Models.Dtos.Responses.Companies;
using Domain.Models.Entities;
using Domain.Repositories.Fundamentals;
using Microsoft.AspNetCore.Http;

namespace Domain.Repositories
{
    public class CompanyRepository : Repository<long, Company, GetCompanyRequest, GetCompaniesRequest, CompanyResponse>, ICompanyRepository
    {
        public CompanyRepository(DbFactory dbFactory,
                                        IMapper mapper,
                                        IHttpContextAccessor httpContext)
            : base(dbFactory, mapper, httpContext)
        {
        }
    }
}
