using Exchange.Communicator.Fixer.io.Request;
using Exchange.Communicator.Fixer.io.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Communicator.Fixer.io
{
    public interface IFixerioCommunicator
    {
        FixerioRatesResponse GetRates(FixerioGetRatesRequest model);
        FixerioGetCurrenciesResponse GetSymbols();
    }
}
