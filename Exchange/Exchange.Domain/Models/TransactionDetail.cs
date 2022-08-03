using Exchange.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Domain.Models
{
    public class TransactionDetail : SimpleEntity
    {
        public Guid TransactionId { get; set; }
        public string Destination { get; set; }
        public decimal DestinationRate { get; set; }

        virtual public Transaction Transaction { get; set; }
    }
}
