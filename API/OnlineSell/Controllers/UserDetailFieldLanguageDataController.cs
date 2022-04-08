using Domain.Controllers;
using Domain.Helpers.ConstVariables;
using Domain.Interfaces.Globals.Controllers;
using Domain.Interfaces.Globals.DataServices;
using Domain.Models.Dtos.Requests.UserDetailFieldLanguageDatas;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineSellAPI.Controllers
{
    public class UserDetailFieldLanguageDataController : BaseController, IUserDetailFieldLanguageDataController
    {
        private readonly IUserDetailFieldLanguageDataService _UserDetailFieldLanguageDataService;
        public UserDetailFieldLanguageDataController(IUserDetailFieldLanguageDataService UserDetailFieldLanguageDataService)
        {
            this._UserDetailFieldLanguageDataService = UserDetailFieldLanguageDataService;
        }
        [HttpDelete(HttpNames.BachDelete)]
        public async Task<IActionResult> BachDelete([FromForm] IList<DeleteUserDetailFieldLanguageDataRequest> request)
        {
            await _UserDetailFieldLanguageDataService.BatchDelete(request);
            return Ok();
        }

        [HttpDelete(HttpNames.Delete)]
        public async Task<IActionResult> Delete([FromForm] DeleteUserDetailFieldLanguageDataRequest request)
        {
            await _UserDetailFieldLanguageDataService.Delete(request);
            return Ok();
        }
        [HttpGet(HttpNames.Get)]
        public async Task<IActionResult> Get([FromQuery] GetUserDetailFieldLanguageDataRequest request, bool includeDeleted = false)
        {
            return Ok(await _UserDetailFieldLanguageDataService.GetById(request, includeDeleted));
        }

        [HttpGet(HttpNames.Gets)]
        public async Task<IActionResult> Gets([FromQuery][ModelBinder] GetUserDetailFieldsLanguageDataRequest request, bool includeDeleted = false)
        {
            var result = await _UserDetailFieldLanguageDataService.Get(request, includeDeleted);
            return Ok(result);
        }
    }
}
