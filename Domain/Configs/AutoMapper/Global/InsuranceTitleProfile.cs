using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Configs.AutoMapper.Global
{
    public class InsuranceTitleProfile : Profile
    {
        public InsuranceTitleProfile()
        {
            #region Reuests
            CreateMap<Models.Dtos.Requests.InsuranceTitles.AddInsuranceTitleRequest, Models.Entities.InsuranceTitle>().ReverseMap();
            CreateMap<Models.Dtos.Requests.InsuranceTitles.EditInsuranceTitleRequest, Models.Entities.InsuranceTitle>().ReverseMap();
            CreateMap<Models.Dtos.Requests.InsuranceTitles.DeleteInsuranceTitleRequest, Models.Entities.InsuranceTitle>().ReverseMap();
            CreateMap<Models.Dtos.Requests.InsuranceTitles.GetInsuranceTitleRequest, Models.Entities.InsuranceTitle>().ReverseMap();
            CreateMap<Models.Dtos.Requests.InsuranceTitles.GetInsuranceTitlesRequest, Models.Entities.InsuranceTitle>().ReverseMap();
            #endregion Reuests
            #region Responses
            CreateMap<Models.Dtos.Responses.InsuranceTitles.InsuranceTitleResponse, Models.Entities.InsuranceTitle>().ReverseMap(); 
            #endregion Responses

        }
    }
}
