using Domain.Controllers;
using Domain.Helpers.ConstVariables;
using Domain.Models.Dtos.Requests.People;
using Domain.Models.Dtos.Responses.PersonLanguageDatas;
using Domain.Models.Dtos.Responses.People;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces.Globals.DataServices;
using Domain.Interfaces.Globals.Controllers;

namespace OnlineSellAPI.Controllers
{
    public class PersonController : BaseController, IPersonController
    {
        private readonly IPersonService _PersonService;

        public PersonController(IPersonService PersonService)
        {
            this._PersonService = PersonService;
        }
        [HttpPost(HttpNames.BachDelete)]
        public async Task<IActionResult> BachDelete([FromForm] IList<DeletePersonRequest> request)
        {
            await _PersonService.BatchDelete(request);
            return Ok();

        }
        [HttpDelete(HttpNames.Delete)]
        public async Task<IActionResult> Delete([FromForm] DeletePersonRequest request)
        {
            await _PersonService.Delete(request);
            return Ok();
        }
        [HttpGet(HttpNames.Get)]
        public async Task<IActionResult> Get([FromQuery] GetPersonRequest request, bool includeDeleted = false)
        {
            return Ok(await _PersonService.GetById(request, includeDeleted));
        }
        [HttpGet("GetGenders")]
        public async Task<IActionResult> GetGenders()
        {
            return Ok(await _PersonService.GetGenders());
        }

        [HttpGet(HttpNames.Gets)]
        public async Task<IActionResult> Gets([FromQuery][ModelBinder] GetPeopleRequest request, bool includeDeleted = false)
        {
            var result = await _PersonService.Get<long, PersonResponse, PersonLanguageDataResponse>(request);
            return Ok(result);
        }
        [AllowAnonymous]
        [HttpPost(HttpNames.Add)]
        public async Task<IActionResult> Post(AddPersonRequest request)
        {
            var result = await _PersonService.Add(request);
            return CreatedAtAction(nameof(Get), new { id = result.Id }, result);

        }
        [Microsoft.AspNetCore.Cors.EnableCors(Globals.CorsName)]
        [HttpPut(HttpNames.Update)]
        public async Task<IActionResult> Put(EditPersonRequest request)
        {
            var result = await _PersonService.Update(request);
            return CreatedAtAction(nameof(Get), new { id = result.Id }, result);
        }
    }
}
