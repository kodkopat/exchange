using Exchange.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Exchange.Domain.Mappings
{
    public class TransactionDetailMapping : BaseMapping<TransactionDetail>
    {
        protected override void Map(EntityTypeBuilder<TransactionDetail> eb)
        {
            eb.Property(c => c.Destination).HasMaxLength(10).IsRequired();
            eb.ToTable("TransactionDetail");
        }
    }
}
