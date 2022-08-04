using Exchange.Communicator.Fixer.io;
using Exchange.Contract.Request.Query;
using Exchange.Contract.Response.Query;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
namespace Exchange.Application.Handlers.Queries
{
    public class GetCurrenciesQueryHandler : IRequestHandler<GetCurrenciesQuery, GetCurrenciesQueryResult>
    {

        private readonly IFixerioCommunicator _communicator;
        public GetCurrenciesQueryHandler(IFixerioCommunicator communicator)
        {

            _communicator = communicator;
        }


        public async Task<GetCurrenciesQueryResult> Handle(GetCurrenciesQuery request, CancellationToken cancellationToken)
        {

            return new GetCurrenciesQueryResult()
            {
               symbols = _communicator.GetSymbols().symbols
            };
        }


    }
}
