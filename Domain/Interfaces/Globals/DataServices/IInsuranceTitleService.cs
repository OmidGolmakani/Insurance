using Domain.Interfaces.Fundamentals.DataService;
using Domain.Models.Dtos.Requests.InsuranceTitles;
using Domain.Models.Dtos.Responses.InsuranceTitles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Globals.DataServices
{
    public interface IInsuranceTitleService : IService<AddInsuranceTitleRequest, EditInsuranceTitleRequest, DeleteInsuranceTitleRequest, InsuranceTitleResponse>,
                                              IGetService<GetInsuranceTitleRequest, GetInsuranceTitlesRequest, InsuranceTitleResponse>
    {

    }
}
