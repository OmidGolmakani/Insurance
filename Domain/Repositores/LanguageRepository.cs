using AutoMapper;
using Domain.Data.DbContext;
using Domain.Interfaces.Globals.Repositories;
using Domain.Models.Dtos.Requests.Languages;
using Domain.Models.Dtos.Responses.Languages;
using Domain.Models.Entities;
using Domain.Repositories.Fundamentals;
using Microsoft.AspNetCore.Http;

namespace Domain.Repositories
{
    public class LanguageRepository : Repository<int, Language, GetLanguageRequest, GetLanguagesRequest, LanguageResponse>, ILanguageRepository
    {
        public LanguageRepository(DbFactory dbFactory,
                                  IMapper mapper,
                                  IHttpContextAccessor httpContext)
            : base(dbFactory, mapper, httpContext)
        {
        }
    }
}
