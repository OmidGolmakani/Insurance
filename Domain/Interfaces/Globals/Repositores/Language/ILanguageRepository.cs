using Domain.Interfaces.Fundamentals.Repository;
using Domain.Models.Dtos.Requests.Languages;
using Domain.Models.Dtos.Responses.Languages;
using Domain.Models.Entities;

namespace Domain.Interfaces.Globals.Repositories
{
    public interface ILanguageRepository : IRepository<int, Language, GetLanguageRequest, GetLanguagesRequest, LanguageResponse>
    {

    }
}
