using Exchange.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Domain.Models
{
    public class Transaction : SimpleEntity
    {
        public DateTime Date { get; set; }
        public string AccountId { get; set; }
        public string Source { get; set; }
        public decimal SourceRate { get; set; }

        virtual public ICollection<TransactionDetail> TransactionDetail { get; set; }
    }
}
