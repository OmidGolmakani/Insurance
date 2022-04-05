using AutoMapper;
using Domain.Interfaces.Fundamentals.Repository;
using Domain.Interfaces.Globals.DataServices;
using Domain.Models.Dtos.Requests.Languages;
using Domain.Models.Dtos.Responses.Languages;
using Domain.Models.Entities;
using Domain.Services.Data.Fundamentals;
using FluentValidation;

namespace Domain.Services.Data.Global
{
    public class LanguageService : Service<int,
                                                  Language,
                                                  GetLanguageRequest,
                                                  GetLanguagesRequest,
                                                  LanguageResponse,
                                                  AddLanguageRequest,
                                                  EditLanguageRequest,
                                                  DeleteLanguageRequest>, 
        ILanguageService
    {
        public LanguageService(IRepository<int,
                                                  Language,
                                                  GetLanguageRequest,
                                                  GetLanguagesRequest,
                                                  LanguageResponse> repository,
            IMapper mapper, IUnitOfWork unitOfWork, IValidator<Language> validator) :
            base(repository, mapper, unitOfWork, validator)
        {
        }
    }
}
