using Microsoft.AspNetCore.Mvc;

namespace Exchange.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ListingController : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> Post()
        {
            return Ok();
        }
    }
}