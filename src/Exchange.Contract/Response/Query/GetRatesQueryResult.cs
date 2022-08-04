using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Contract.Response.Query
{
    public class GetRatesQueryResult
    {
        public string Source { get; set; }
        public dynamic Destination { get; set; }
    }
}
