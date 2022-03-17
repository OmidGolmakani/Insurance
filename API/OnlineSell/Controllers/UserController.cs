using Domain.Controllers;
using Domain.Helpers.ConstVariables;
using Domain.Interfaces.Globals.Controllers;
using Domain.Interfaces.Globals.DataServices;
using Domain.Models.Dtos.Requests.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineSellAPI.Controllers
{
    public class UserController : BaseController, IUserController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            this._userService = userService;
        }
        [HttpPost(HttpNames.BatchUpdate)]
        public async Task<IActionResult> BachDelete([FromForm] IList<DeleteUserRequest> request)
        {
            await _userService.BatchDelete(request);
            return Ok();

        }
        [HttpDelete(HttpNames.Delete)]
        public async Task<IActionResult> Delete([FromForm] DeleteUserRequest request)
        {
            await _userService.Delete(request);
            return Ok();
        }
        [HttpGet(HttpNames.Get)]
        public async Task<IActionResult> Get([FromQuery] GetUserRequest request, bool includeDeleted = false)
        {
            return Ok(await _userService.GetAsync(request));
        }
        [HttpPost("GetEmailVerification")]
        public Task GetEmailVerification(GetUserRequest request)
        {
            throw new NotImplementedException();
        }
        [HttpPost("GetPhoneNumberVerification")]
        public Task GetPhoneNumberVerification(GetUserRequest request)
        {
            throw new NotImplementedException();
        }

        [HttpGet(HttpNames.Gets)]
        public async Task<IActionResult> Gets([FromQuery] GetUsersRequest request, bool includeDeleted = false)
        {
            return Ok(await _userService.GetsAsync(request));
        }
        [AllowAnonymous]
        [HttpPost(HttpNames.Add)]
        public async Task<IActionResult> Post([FromForm] AddUserRequest request)
        {
            var result = await _userService.Add(request);
            return CreatedAtAction(nameof(Get), new { id = result.Id }, result);

        }
        [Microsoft.AspNetCore.Cors.EnableCors(Globals.CorsName)]
        [HttpPut(HttpNames.Update)]
        public async Task<IActionResult> Put([FromForm] EditUserRequest request)
        {
            var result = await _userService.Update(request);
            return CreatedAtAction(nameof(Get), new { id = result.Id }, result);
        }
        [AllowAnonymous]
        [HttpPost("Signin")]
        public async Task<IActionResult> SigninAsync([FromForm] LoginRequst requst)
        {
            return Ok(await _userService.SignInAsync(requst));
        }
        [HttpPost("Signout")]
        public async Task SignoutAsync()
        {
            await _userService.SignoutAsync();
        }
    }
}
