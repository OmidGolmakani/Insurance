using AutoMapper;
using Domain.Data.DbContext;
using Domain.Interfaces.Globals.Repositories;
using Domain.Models.Dtos.Requests.People;
using Domain.Models.Dtos.Responses.People;
using Domain.Models.Entities;
using Domain.Repositories.Fundamentals;
using Microsoft.AspNetCore.Http;

namespace Domain.Repositories
{
    public class PersonRepository : Repository<long, 
                                               Person, 
                                               GetPersonRequest, 
                                               GetPeopleRequest, 
                                               PersonResponse>, 
                                               IPersonRepository
    {
        public PersonRepository(DbFactory dbFactory,
                                                    IMapper mapper,
                                                    IHttpContextAccessor httpContext)
            : base(dbFactory, mapper, httpContext)
        {
        }
    }
}
