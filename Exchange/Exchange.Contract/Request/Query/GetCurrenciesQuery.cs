using Exchange.Contract.Response.Query;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Contract.Request.Query
{
    public class GetCurrenciesQuery : IRequest<GetCurrenciesQueryResult>
    {
    }
}
