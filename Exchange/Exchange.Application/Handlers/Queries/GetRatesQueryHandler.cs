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

            var res = _communicator.GetRates(new Communicator.Fixer.io.Request.FixerioGetRatesRequest
            {
                Source = request.Source,
                Destenations = request.Destination
            });

            return new GetRatesQueryResult()
            {
                Source = res.@base,
                Destination = res.rates
            };
        }


    }
}
