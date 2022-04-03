using Domain.Controllers;
using Domain.Helpers.ConstVariables;
using Domain.Interfaces.Globals.Controllers;
using Domain.Interfaces.Globals.DataServices;
using Domain.Models.Dtos.Requests.InsuranceTitleLanguageDatas;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineSellAPI.Controllers
{
    public class InsuranceTitleLanguageDataController : BaseController, IInsuranceTitleLanguageDataController
    {
        private readonly IInsuranceTitleLanguageDataService _InsuranceTitleLanguageDataService;
        public InsuranceTitleLanguageDataController(IInsuranceTitleLanguageDataService InsuranceTitleLanguageDataService)
        {
            this._InsuranceTitleLanguageDataService = InsuranceTitleLanguageDataService;
        }
        [HttpDelete(HttpNames.BachDelete)]
        public async Task<IActionResult> BachDelete([FromForm] IList<DeleteInsuranceTitleLanguageDataRequest> request)
        {
            await _InsuranceTitleLanguageDataService.BatchDelete(request);
            return Ok();
        }

        [HttpDelete(HttpNames.Delete)]
        public async Task<IActionResult> Delete([FromForm] DeleteInsuranceTitleLanguageDataRequest request)
        {
            await _InsuranceTitleLanguageDataService.Delete(request);
            return Ok();
        }
        [HttpGet(HttpNames.Get)]
        public async Task<IActionResult> Get([FromQuery] GetInsuranceTitleLanguageDataRequest request, bool includeDeleted = false)
        {
            return Ok(await _InsuranceTitleLanguageDataService.GetById(request, includeDeleted));
        }

        [HttpGet(HttpNames.Gets)]
        public async Task<IActionResult> Gets([FromQuery][ModelBinder] GetInsuranceTitlesLanguageDataRequest request, bool includeDeleted = false)
        {
            var result = await _InsuranceTitleLanguageDataService.Get(request, includeDeleted);
            return Ok(result);
        }
    }
}
