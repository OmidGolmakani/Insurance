using Domain.Controllers;
using Domain.Helpers;
using Domain.Helpers.ConstVariables;
using Domain.Interfaces.Globals.Controllers;
using Domain.Interfaces.Globals.DataServices;
using Domain.Models.Dtos.Requests.Languages;
using Domain.Models.Entities;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineSellAPI.Controllers
{
    public class LanguageController : BaseController, ILanguageController
    {
        private readonly ILanguageService _LanguageService;

        public LanguageController(ILanguageService LanguageService)
        {
            this._LanguageService = LanguageService;
        }
        [HttpPost(HttpNames.BachDelete)]
        public async Task<IActionResult> BachDelete([FromForm] IList<DeleteLanguageRequest> request)
        {
            await _LanguageService.BatchDelete(request);
            return Ok();

        }
        [HttpDelete(HttpNames.Delete)]
        public async Task<IActionResult> Delete([FromForm] DeleteLanguageRequest request)
        {
            await _LanguageService.Delete(request);
            return Ok();
        }
        [HttpGet(HttpNames.Get)]
        public async Task<IActionResult> Get([FromQuery] GetLanguageRequest request, bool includeDeleted = false)
        {
            return Ok(await _LanguageService.GetById(request, includeDeleted));
        }

        [HttpGet(HttpNames.Gets)]
        public async Task<IActionResult> Gets([FromQuery][ModelBinder] GetLanguagesRequest request, bool includeDeleted = false)
        {
            return Ok(await _LanguageService.Get(request, includeDeleted));
        }
        [AllowAnonymous]
        [HttpPost(HttpNames.Add)]
        public async Task<IActionResult> Post([FromForm] AddLanguageRequest request)
        {
            var result = await _LanguageService.Add(request);
            return CreatedAtAction(nameof(Get), new { id = result.Id }, result);

        }
        [Microsoft.AspNetCore.Cors.EnableCors(Globals.CorsName)]
        [HttpPut(HttpNames.Update)]
        public async Task<IActionResult> Put([FromForm] EditLanguageRequest request)
        {
            var result = await _LanguageService.Update(request);
            return CreatedAtAction(nameof(Get), new { id = result.Id }, result);
        }
    }
}
