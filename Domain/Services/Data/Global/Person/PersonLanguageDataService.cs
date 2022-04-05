using AutoMapper;
using Domain.Interfaces.Fundamentals.Repository;
using Domain.Interfaces.Globals.DataServices;
using Domain.Models.Dtos.Requests.PersonLanguageDatas;
using Domain.Models.Dtos.Responses.PersonLanguageDatas;
using Domain.Models.Entities;
using Domain.Services.Data.Fundamentals;
using FluentValidation;

namespace Domain.Services.Data.Global
{
    public class PersonLanguageDataService : Service<long,
                                                     PersonLanguageData,
                                                     GetPersonLanguageDataRequest,
                                                     GetPeopleLanguageDataRequest,
                                                     PersonLanguageDataResponse,
                                                     AddPersonLanguageDataRequest,
                                                     EditPersonLanguageDataRequest,
                                                     DeletePersonLanguageDataRequest>,
        IPersonLanguageDataService
    {
        public PersonLanguageDataService(IRepository<long,
                                                     PersonLanguageData,
                                                     GetPersonLanguageDataRequest,
                                                     GetPeopleLanguageDataRequest,
                                                     PersonLanguageDataResponse> repository,
            IMapper mapper, IUnitOfWork unitOfWork, IValidator<PersonLanguageData> validator) :
            base(repository, mapper, unitOfWork, validator)
        {
        }
    }
}
