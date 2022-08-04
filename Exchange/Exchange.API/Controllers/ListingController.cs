using Microsoft.AspNetCore.Mvc;

namespace Exchange.API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ExchangeController : ControllerBase
    {


        [HttpGet]

        public async Task<IActionResult> GetCurencyList()
        {
            return Ok();
        }


    }
}