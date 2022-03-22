using AutoMapper;
using Domain.Data.DbContext;
using Domain.Interfaces.Globals.Repositories;
using Domain.Models.Dtos.Requests.InsuranceTitles;
using Domain.Models.Dtos.Responses.InsuranceTitles;
using Domain.Models.Entities;
using Domain.Repositories.Fundamentals;

namespace Domain.Repositories
{
    public class InsuranceTitleRepository : Repository<int, InsuranceTitle, GetInsuranceTitleRequest, GetInsuranceTitlesRequest, InsuranceTitleResponse>, IInsuranceTitleRepository
    {
        public InsuranceTitleRepository(DbFactory dbFactory, IMapper mapper) : base(dbFactory, mapper)
        {
        }
    }
}
