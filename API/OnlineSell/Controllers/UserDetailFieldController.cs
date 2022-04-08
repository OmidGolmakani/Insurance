using Domain.Controllers;
using Domain.Helpers.ConstVariables;
using Domain.Helpers.Globals;
using Domain.Interfaces.Globals.Controllers;
using Domain.Interfaces.Globals.DataServices;
using Domain.Models.Dtos.Requests.UserDetailFields;
using Domain.Models.Dtos.Responses.UserDetailFieldLanguageDatas;
using Domain.Models.Dtos.Responses.UserDetailFields;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineSellAPI.Controllers
{
    public class UserDetailFieldController : BaseController, IUserDetailFieldController
    {
        private readonly IUserDetailFieldService _UserDetailFieldService;

        public UserDetailFieldController(IUserDetailFieldService UserDetailFieldService)
        {
            this._UserDetailFieldService = UserDetailFieldService;
        }
        [HttpPost(HttpNames.BachDelete)]
        public async Task<IActionResult> BachDelete([FromForm] IList<DeleteUserDetailFieldRequest> request)
        {
            await _UserDetailFieldService.BatchDelete(request);
            return Ok();

        }
        [HttpDelete(HttpNames.Delete)]
        public async Task<IActionResult> Delete([FromForm] DeleteUserDetailFieldRequest request)
        {
            await _UserDetailFieldService.Delete(request);
            return Ok();
        }
        [HttpGet(HttpNames.Get)]
        public async Task<IActionResult> Get([FromQuery] GetUserDetailFieldRequest request, bool includeDeleted = false)
        {
            return Ok(await _UserDetailFieldService.GetById(request, includeDeleted));
        }

        [HttpGet(HttpNames.Gets)]
        public async Task<IActionResult> Gets([FromQuery] [ModelBinder] GetUserDetailFieldsRequest request, bool includeDeleted = false)
        {
            var result = await _UserDetailFieldService.Get<long, UserDetailFieldResponse, UserDetailFieldLanguageDataResponse>(request);
            return Ok(result);
        }
        [AllowAnonymous]
        [HttpPost(HttpNames.Add)]
        public async Task<IActionResult> Post(AddUserDetailFieldRequest request)
        {
            var result = await _UserDetailFieldService.Add(request);
            return CreatedAtAction(nameof(Get), new { id = result.Id }, result);

        }
        [Microsoft.AspNetCore.Cors.EnableCors(Globals.CorsName)]
        [HttpPut(HttpNames.Update)]
        public async Task<IActionResult> Put(EditUserDetailFieldRequest request)
        {
            var result = await _UserDetailFieldService.Update(request);
            return CreatedAtAction(nameof(Get), new { id = result.Id }, result);
        }
    }
}
