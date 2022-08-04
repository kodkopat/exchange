using Exchange.Contract.Request.Query;
using Exchange.Contract.Response.Query;
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
        public async Task<GetRatesQueryResult> Handle(GetRatesQuery request, CancellationToken cancellationToken)
        {
            return new GetRatesQueryResult();
        }
    }
}
