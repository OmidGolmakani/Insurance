using Domain.Interfaces.Fundamentals.DataService;
using Domain.Models.Dtos.Requests.InsuranceTitles;
using Domain.Models.Dtos.Responses.InsuranceTitles;
using Domain.Models.Entities;

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
