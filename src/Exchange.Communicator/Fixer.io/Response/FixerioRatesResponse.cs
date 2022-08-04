using System.Dynamic;

namespace Exchange.Communicator.Fixer.io.Response
{
    public class FixerioRatesResponse
    {
        public bool success { get; set; }
        public int timestamp { get; set; }
        public string @base { get; set; }
        public string date { get; set; }
        public ExpandoObject rates { get; set; }
    }
 
}
