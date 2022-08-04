using Exchange.Contract.Request.Command;
using Exchange.Contract.Request.Query;
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
        /// <param name="AccountId">account Id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> List([FromQuery] int AccountId)
        {
            return Ok(await _mediator.Send(new GetTransactionsQuery { AccountId = AccountId }));
        }

        /// <summary>
        /// save new exchange transaction
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Save(SaveTransactionCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}