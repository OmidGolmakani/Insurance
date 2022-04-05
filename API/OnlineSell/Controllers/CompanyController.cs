using Domain.Controllers;
using Domain.Helpers.ConstVariables;
using Domain.Interfaces.Globals.Controllers;
using Domain.Interfaces.Globals.DataServices;
using Domain.Models.Dtos.Requests.Companies;
using Domain.Models.Dtos.Responses.Companies;
using Domain.Models.Dtos.Responses.CompanyLanguageDatas;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineSellAPI.Controllers
{
    public class CompanyController : BaseController, ICompanyController
    {
        private readonly ICompanyService _Companieservice;

        public CompanyController(ICompanyService Companieservice)
        {
            this._Companieservice = Companieservice;
        }
        [HttpPost(HttpNames.BachDelete)]
        public async Task<IActionResult> BachDelete([FromForm] IList<DeleteCompanyRequest> request)
        {
            await _Companieservice.BatchDelete(request);
            return Ok();

        }
        [HttpDelete(HttpNames.Delete)]
        public async Task<IActionResult> Delete([FromForm] DeleteCompanyRequest request)
        {
            await _Companieservice.Delete(request);
            return Ok();
        }
        [HttpGet(HttpNames.Get)]
        public async Task<IActionResult> Get([FromQuery] GetCompanyRequest request, bool includeDeleted = false)
        {
            return Ok(await _Companieservice.GetById(request, includeDeleted));
        }

        [HttpGet(HttpNames.Gets)]
        public async Task<IActionResult> Gets([FromQuery] [ModelBinder] GetCompaniesRequest request, bool includeDeleted = false)
        {
            var result = await _Companieservice.Get<long, CompanyResponse, CompanyLanguageDataResponse>(request);
            return Ok(result);
        }
        [AllowAnonymous]
        [HttpPost(HttpNames.Add)]
        public async Task<IActionResult> Post(AddCompanyRequest request)
        {
            var result = await _Companieservice.Add(request);
            return CreatedAtAction(nameof(Get), new { id = result.Id }, result);

        }
        [Microsoft.AspNetCore.Cors.EnableCors(Globals.CorsName)]
        [HttpPut(HttpNames.Update)]
        public async Task<IActionResult> Put(EditCompanyRequest request)
        {
            var result = await _Companieservice.Update(request);
            return CreatedAtAction(nameof(Get), new { id = result.Id }, result);
        }
    }
}
