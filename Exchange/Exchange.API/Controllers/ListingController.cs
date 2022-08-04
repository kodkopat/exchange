using Exchange.Contract.Request.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Exchange.API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ListingController : ControllerBase
    {
        public readonly IMediator _mediator;

        public ListingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetCurrencies()
        {
            return Ok(await _mediator.Send(new GetCurrenciesQuery()));
        }


    }
}