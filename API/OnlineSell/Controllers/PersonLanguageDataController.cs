using Domain.Controllers;
using Domain.Helpers.ConstVariables;
using Domain.Interfaces.Globals.Controllers;
using Domain.Interfaces.Globals.DataServices;
using Domain.Models.Dtos.Requests.PersonLanguageDatas;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineSellAPI.Controllers
{
    public class PersonLanguageDataController : BaseController, IPersonLanguageDataController
    {
        private readonly IPersonLanguageDataService _PersonLanguageDataService;
        public PersonLanguageDataController(IPersonLanguageDataService PersonLanguageDataService)
        {
            this._PersonLanguageDataService = PersonLanguageDataService;
        }
        [HttpDelete(HttpNames.BachDelete)]
        public async Task<IActionResult> BachDelete([FromForm] IList<DeletePersonLanguageDataRequest> request)
        {
            await _PersonLanguageDataService.BatchDelete(request);
            return Ok();
        }

        [HttpDelete(HttpNames.Delete)]
        public async Task<IActionResult> Delete([FromForm] DeletePersonLanguageDataRequest request)
        {
            await _PersonLanguageDataService.Delete(request);
            return Ok();
        }
        [HttpGet(HttpNames.Get)]
        public async Task<IActionResult> Get([FromQuery] GetPersonLanguageDataRequest request, bool includeDeleted = false)
        {
            return Ok(await _PersonLanguageDataService.GetById(request, includeDeleted));
        }

        [HttpGet(HttpNames.Gets)]
        public async Task<IActionResult> Gets([FromQuery][ModelBinder] GetPeopleLanguageDataRequest request, bool includeDeleted = false)
        {
            var result = await _PersonLanguageDataService.Get(request, includeDeleted);
            return Ok(result);
        }
    }
}
