using Domain.Interfaces.Fundamentals.DataService;
using Domain.Models.Dtos.Requests.Languages;
using Domain.Models.Dtos.Responses.Languages;
using Domain.Models.Entities;

namespace Domain.Interfaces.Globals.DataServices
{
    public interface ILanguageService : IService<int,
                                                 Language,
                                                 AddLanguageRequest,
                                                 EditLanguageRequest,
                                                 DeleteLanguageRequest,
                                                 GetLanguageRequest,
                                                 GetLanguagesRequest,
                                                 LanguageResponse>
    {

    }
}
