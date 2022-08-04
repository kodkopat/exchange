using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Contract.Response.Query
{
    public class GetCurrenciesQueryResult
    {
    
        public ExpandoObject symbols { get; set; }
    }
}
