using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Domain.DataTransferObjects
{
    public class TransactionGetDTO
    {
        public DateTime Date { get; set; }
        public string Source { get; set; }
        public decimal SourceAmount { get; set; }

        public ICollection<TransactionDetailGetDTO> TransactionDetail { get; set; }
    }
}
