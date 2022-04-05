using Domain.Controllers;
using Domain.Helpers.ConstVariables;
using Domain.Interfaces.Globals.Controllers;
using Domain.Interfaces.Globals.DataServices;
using Domain.Models.Dtos.Requests.CompanyLanguageDatas;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineSellAPI.Controllers
{
    public class CompanyLanguageDataController : BaseController, ICompanyLanguageDataController
    {
        private readonly ICompanyLanguageDataService _CompanyLanguageDataService;
        public CompanyLanguageDataController(ICompanyLanguageDataService CompanyLanguageDataService)
        {
            this._CompanyLanguageDataService = CompanyLanguageDataService;
        }
        [HttpDelete(HttpNames.BachDelete)]
        public async Task<IActionResult> BachDelete([FromForm] IList<DeleteCompanyLanguageDataRequest> request)
        {
            await _CompanyLanguageDataService.BatchDelete(request);
            return Ok();
        }

        [HttpDelete(HttpNames.Delete)]
        public async Task<IActionResult> Delete([FromForm] DeleteCompanyLanguageDataRequest request)
        {
            await _CompanyLanguageDataService.Delete(request);
            return Ok();
        }
        [HttpGet(HttpNames.Get)]
        public async Task<IActionResult> Get([FromQuery] GetCompanyLanguageDataRequest request, bool includeDeleted = false)
        {
            return Ok(await _CompanyLanguageDataService.GetById(request, includeDeleted));
        }

        [HttpGet(HttpNames.Gets)]
        public async Task<IActionResult> Gets([FromQuery][ModelBinder] GetCompaniesLanguageDataRequest request, bool includeDeleted = false)
        {
            var result = await _CompanyLanguageDataService.Get(request, includeDeleted);
            return Ok(result);
        }
    }
}
