using Domain.Interfaces.Fundamentals.Controller;
using Domain.Models.Dtos.Requests.InsuranceTitles;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Domain.Interfaces.Globals.Controllers
{
    public interface IInsuranceTitleController : IController<AddInsuranceTitleRequest, EditInsuranceTitleRequest, DeleteInsuranceTitleRequest>,
                                                 IGetController<GetInsuranceTitleRequest, GetInsuranceTitlesRequest>
    {
       
    }
}
