using Exchange.Domain.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Contract.Response.Query
{
    public class GetTransactionsQueryResult
    {
        public ICollection<TransactionGetDTO> Transactions { get; set; }
    }


}
