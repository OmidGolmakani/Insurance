using Domain.Controllers;
using Domain.Helpers.ConstVariables;
using Domain.Interfaces.Globals.Controllers;
using Domain.Interfaces.Globals.DataServices;
using Domain.Models.Dtos.Requests.InsuranceTitles;
using Domain.Models.Dtos.Responses.InsuranceTitleLanguageDatas;
using Domain.Models.Dtos.Responses.InsuranceTitles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineSellAPI.Controllers
{
    public class InsuranceTitleController : BaseController, IInsuranceTitleController
    {
        private readonly IInsuranceTitleService _InsuranceTitleService;

        public InsuranceTitleController(IInsuranceTitleService InsuranceTitleService)
        {
            this._InsuranceTitleService = InsuranceTitleService;
        }
        [HttpPost(HttpNames.BachDelete)]
        public async Task<IActionResult> BachDelete([FromForm] IList<DeleteInsuranceTitleRequest> request)
        {
            await _InsuranceTitleService.BatchDelete(request);
            return Ok();

        }
        [HttpDelete(HttpNames.Delete)]
        public async Task<IActionResult> Delete([FromForm] DeleteInsuranceTitleRequest request)
        {
            await _InsuranceTitleService.Delete(request);
            return Ok();
        }
        [HttpGet(HttpNames.Get)]
        public async Task<IActionResult> Get([FromQuery] GetInsuranceTitleRequest request, bool includeDeleted = false)
        {
            return Ok(await _InsuranceTitleService.GetById(request, includeDeleted));
        }

        [HttpGet(HttpNames.Gets)]
        public async Task<IActionResult> Gets([FromQuery] GetInsuranceTitlesRequest request, bool includeDeleted = false)
        {
            var result = await _InsuranceTitleService.Get<int, InsuranceTitleResponse, InsuranceTitleLanguageDataResponse>(request);
            return Ok(result);
        }
        [AllowAnonymous]
        [HttpPost(HttpNames.Add)]
        public async Task<IActionResult> Post([FromForm] AddInsuranceTitleRequest request)
        {
            var result = await _InsuranceTitleService.Add(request);
            return CreatedAtAction(nameof(Get), new { id = result.Id }, result);

        }
        [Microsoft.AspNetCore.Cors.EnableCors(Globals.CorsName)]
        [HttpPut(HttpNames.Update)]
        public async Task<IActionResult> Put([FromForm] EditInsuranceTitleRequest request)
        {
            var result = await _InsuranceTitleService.Update(request);
            return CreatedAtAction(nameof(Get), new { id = result.Id }, result);
        }
    }
}
