using Domain.Models.Entities;
using Domain.Interfaces.Fundamentals.DataService;
using Domain.Models.Dtos.Requests.InsuranceTitles;
using Domain.Models.Dtos.Responses.InsuranceTitles;
using Domain.Models.Validations.InsuranceTitle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Globals.DataServices
{
    public interface IInsuranceTitleService : IService<int,
                                              InsuranceTitle,
                                              AddInsuranceTitleRequest,
                                              EditInsuranceTitleRequest,
                                              DeleteInsuranceTitleRequest,
                                              GetInsuranceTitleRequest,
                                              GetInsuranceTitlesRequest,
                                              InsuranceTitleResponse>
    {

    }
}
