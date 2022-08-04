using System.Dynamic;

namespace Exchange.Communicator.Fixer.io.Response
{
    public class FixerioGetCurrenciesResponse
    {
        public bool success { get; set; }
        public ExpandoObject symbols { get; set; }
    }

}
