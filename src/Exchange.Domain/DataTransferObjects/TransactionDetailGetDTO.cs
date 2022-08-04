using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Domain.DataTransferObjects
{
    public class TransactionDetailGetDTO
    {
        public string Destination { get; set; }
        public decimal DestinationAmount { get; set; }
    }
}
