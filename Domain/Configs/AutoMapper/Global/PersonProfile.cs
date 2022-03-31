using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Configs.AutoMapper.Global
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            #region Reuests
            CreateMap<Models.Dtos.Requests.People.AddPersonRequest, Models.Entities.Person>()
                 .ForMember(dest => dest.PersonLanguageDatas, opts => opts.MapFrom(src => src.LanguageDatas));

            CreateMap<Models.Entities.Person,Models.Dtos.Requests.People.AddPersonRequest>();


            CreateMap<Models.Dtos.Requests.People.EditPersonRequest, Models.Entities.Person>()
                 .ForMember(dest => dest.PersonLanguageDatas, opts => opts.MapFrom(src => src.LanguageDatas));

            CreateMap<Models.Entities.Person, Models.Dtos.Requests.People.EditPersonRequest>();

            CreateMap<Models.Dtos.Requests.People.DeletePersonRequest, Models.Entities.Person>().ReverseMap();
            CreateMap<Models.Dtos.Requests.People.GetPersonRequest, Models.Entities.Person>().ReverseMap();
            CreateMap<Models.Dtos.Requests.People.GetPeopleRequest, Models.Entities.Person>().ReverseMap();
            #endregion Reuests
            #region Responses
            CreateMap<Models.Dtos.Responses.People.PersonResponse, Models.Entities.Person>().ReverseMap(); 
            #endregion Responses

        }
    }
}
