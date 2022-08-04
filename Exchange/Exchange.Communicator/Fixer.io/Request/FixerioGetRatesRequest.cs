using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Communicator.Fixer.io.Request
{
    public class FixerioGetRatesRequest
    {
        public string Source { get; set; }
        public List<string> Destenations { get; set; }
    }
}
