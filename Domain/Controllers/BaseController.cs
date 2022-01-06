using Microsoft.AspNetCore.Mvc;


namespace Domain.Controllers
{
    [Microsoft.AspNetCore.Cors.EnableCors("Insurance")]
    [Route("api/[controller]")]
    [Produces(typeof(JsonResult))]
    [ApiController]
    //[CustomAuthorizationFilter]
    public class BaseController : ControllerBase
    {
    }
}
