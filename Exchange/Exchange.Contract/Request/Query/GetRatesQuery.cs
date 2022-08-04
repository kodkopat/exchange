using Exchange.Contract.Response.Query;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Contract.Request.Query
{
    public class GetRatesQuery : IRequest<GetRatesQueryResult>
    {
        public string Source { get; set; }
        public List<string> Destination { get; set; }
    }
}
