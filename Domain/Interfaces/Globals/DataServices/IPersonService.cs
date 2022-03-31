using Domain.Interfaces.Fundamentals.DataService;
using Domain.Models.Dtos.Requests.People;
using Domain.Models.Dtos.Responses.People;
using Domain.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Globals.DataServices
{
    public interface IPersonService : IService<long,
                                              Person,
                                              AddPersonRequest,
                                              EditPersonRequest,
                                              DeletePersonRequest,
                                              GetPersonRequest,
                                              GetPeopleRequest,
                                              PersonResponse>
    {
        Task<List<(byte, string, string)>> GetGenders();
    }
}
