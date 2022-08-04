using Exchange.Contract.Request.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Exchange.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExchangeRateController : ControllerBase
    {
        public readonly IMediator _mediator;

        public ExchangeRateController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Get([FromBody] GetRatesQuery model)
        {
            var res = await _mediator.Send(model);
            return Ok(res);
        }
    }
}