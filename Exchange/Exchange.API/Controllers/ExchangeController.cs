using Exchange.Contract.Request.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Exchange.API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ExchangeController : ControllerBase
    {
        public readonly IMediator _mediator;

        public ExchangeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// get all transactions for spesific user
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> List()
        {
            return Ok();
        }

        /// <summary>
        /// save new exchange transaction
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Save(SaveTransactionCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}