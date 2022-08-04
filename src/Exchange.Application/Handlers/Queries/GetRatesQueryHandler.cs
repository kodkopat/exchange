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
    public class GetRatesQueryHandler : IRequestHandler<GetRatesQuery, GetRatesQueryResult>

    {
        private readonly IValidator<GetRatesQuery> _validator;
        private readonly IFixerioCommunicator _communicator;

        public GetRatesQueryHandler(IValidator<GetRatesQuery> validator, IFixerioCommunicator communicator)
        {
            _validator = validator;
            _communicator = communicator;
        }


        public async Task<GetRatesQueryResult> Handle(GetRatesQuery request, CancellationToken cancellationToken)
        {
            _validator.ValidateAndThrow(request);

            //check if requested symbols existed in service
            var symbols = _communicator.GetSymbols().symbols;
            request.Destination.ForEach(x =>
            {
                if (!symbols.Select(x => x.Key).Contains(x))
                    throw new Exception("requested Symbol not found");
            });

            if (!symbols.Select(c => c.Key).Any(c => c == request.Source))
                throw new Exception("requested Symbol not found");


            var rates = _communicator.GetRates(new Communicator.Fixer.io.Request.FixerioGetRatesRequest
            {
                Source = request.Source,
                Destenations = request.Destination
            });
            return new GetRatesQueryResult()
            {
                Source = rates.@base,
                Destination = rates.rates
            };
        }


    }
}
