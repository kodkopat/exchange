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
    public class TransactionMapping : BaseMapping<Transaction>
    {
        protected override void Map(EntityTypeBuilder<Transaction> eb)
        {
            eb.Property(c => c.Source).HasMaxLength(10).IsRequired();
            eb.Property(c => c.SourceRate).IsRequired();
            eb.HasMany(c => c.TransactionDetail).WithOne(c => c.Transaction).HasForeignKey(c => c.TransactionId).IsRequired().OnDelete(DeleteBehavior.Cascade);
            eb.ToTable("Transaction");
        }
    }
}
