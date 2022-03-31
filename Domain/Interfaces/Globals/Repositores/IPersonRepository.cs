using Domain.Interfaces.Fundamentals.Repository;
using Domain.Models.Dtos.Requests.People;
using Domain.Models.Dtos.Responses.People;
using Domain.Models.Entities;

namespace Domain.Interfaces.Globals.Repositories
{
    public interface IPersonRepository : IRepository<long,
                                                      Person,
                                                      GetPersonRequest,
                                                      GetPeopleRequest,
                                                      PersonResponse>
    {

    }
}
