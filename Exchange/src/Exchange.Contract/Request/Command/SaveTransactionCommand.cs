using Exchange.Contract.Response.Query;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Contract.Request.Command
{
    public class SaveTransactionCommand : IRequest<SaveTransactionCommandResult>
    {
        public int AccountId { get; set; }
        public string Source { get; set; }
        public decimal SourceAmount { get; set; }
        public List<string> Destination { get; set; }
    }
}
