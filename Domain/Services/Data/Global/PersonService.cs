using AutoMapper;
using Domain.Interfaces.Fundamentals.Repository;
using Domain.Interfaces.Globals.DataServices;
using Domain.Models.Dtos.Requests.People;
using Domain.Models.Dtos.Responses.People;
using Domain.Models.Entities;
using Domain.Services.Data.Fundamentals;
using FluentValidation;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Services.Data.Global
{
    public class PersonService : Service<long,
                                         Person,
                                         GetPersonRequest,
                                         GetPeopleRequest,
                                         PersonResponse,
                                         AddPersonRequest,
                                         EditPersonRequest,
                                         DeletePersonRequest>, 
        IPersonService
    {
        public PersonService(IRepository<long,
                                         Person,
                                         GetPersonRequest,
                                         GetPeopleRequest,
                                         PersonResponse> repository,
            IMapper mapper, IUnitOfWork unitOfWork, IValidator<Person> validator) :
            base(repository, mapper, unitOfWork, validator)
        {
        }

        public async Task<List<(byte, string, string)>> GetGenders()
        {
            Models.Enums.Person.Gender gender = Models.Enums.Person.Gender.Female;
            return await Task.Run(() => Helpers.Globals.Enumerated.GetDisplayNames<Models.Enums.Person.Gender>(gender));
        }
    }
}
