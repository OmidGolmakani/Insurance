using Domain.Helpers.ConstVariables;
using Microsoft.AspNetCore.Mvc;


namespace Domain.Controllers
{
    [Route("api/[controller]")]
    [Produces(typeof(JsonResult))]
    [ApiController]
    [Microsoft.AspNetCore.Cors.EnableCors(Globals.CorsName)]
    //[CustomAuthorizationFilter]
    public class BaseController : ControllerBase
    {
    }
}
