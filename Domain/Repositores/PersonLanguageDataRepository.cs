using AutoMapper;
using Domain.Data.DbContext;
using Domain.Interfaces.Globals.Repositories;
using Domain.Models.Dtos.Requests.PersonLanguageDatas;
using Domain.Models.Dtos.Responses.PersonLanguageDatas;
using Domain.Models.Entities;
using Domain.Repositories.Fundamentals;
using Microsoft.AspNetCore.Http;

namespace Domain.Repositories
{
    public class PersonLanguageDataRepository : Repository<long, 
                                                                   PersonLanguageData, 
                                                                   GetPersonLanguageDataRequest, 
                                                                   GetPeopleLanguageDataRequest, 
                                                                   PersonLanguageDataResponse>, 
                                                                   IPersonLanguageDataRepository
    {
        public PersonLanguageDataRepository(DbFactory dbFactory,
                                                    IMapper mapper,
                                                    IHttpContextAccessor httpContext)
            : base(dbFactory, mapper, httpContext)
        {
        }
    }
}
