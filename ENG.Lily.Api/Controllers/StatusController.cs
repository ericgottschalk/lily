using Microsoft.AspNetCore.Mvc;

namespace ENG.Lily.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/status")]
    public class StatusController : Controller
    {
        public IActionResult Status()
        {
            return Ok("ON LIVE");
        }
    }
}