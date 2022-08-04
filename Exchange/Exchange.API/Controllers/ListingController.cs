using Microsoft.AspNetCore.Mvc;

namespace Exchange.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExchangeController : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            return Ok();
        }
    }
}