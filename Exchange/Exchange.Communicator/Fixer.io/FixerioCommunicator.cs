using Exchange.Common;
using Exchange.Communicator.Fixer.io.Request;
using Exchange.Communicator.Fixer.io.Response;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Communicator.Fixer.io
{
    public class FixerioCommunicator : IFixerioCommunicator
    {

        public FixerioRatesResponse GetRates(FixerioGetRatesRequest model)
        {
            string url = $"{Settings.RateService.Fixer}latest?{GenerateUrl(model)}";
            var client = new RestClient(url);
            var request = new RestRequest();
            request.AddHeader("apikey", Settings.RateService.ApiKey);
            request.Method = Method.Get;
            var response = client.Get<FixerioRatesResponse>(request);
            return response;
        }
        public FixerioSymbolsResponse GetSymbols()
        {
            string url = $"{Settings.RateService.Fixer}symbols";
            var client = new RestClient(url);
            var request = new RestRequest();
            request.AddHeader("apikey", Settings.RateService.ApiKey);
            request.Method = Method.Get;
            var response = client.Get<FixerioSymbolsResponse>(request);
            return response;
        }
        private string GenerateUrl(FixerioGetRatesRequest model)
        {
            return $"base={model.Source}&symbols={string.Join(',', model.Destenations)}";
        }
    }
}
