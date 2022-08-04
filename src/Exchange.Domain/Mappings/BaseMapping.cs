using Exchange.Domain.Models.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Domain.Mappings
{
    public abstract class BaseMapping<T> where T : class, IEntity
    {
        protected abstract void Map(EntityTypeBuilder<T> eb);

        public void BaseMap(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<T>(bi =>
            {
                bi.HasKey(b => b.Id);
                Map(bi);
            });
        }
    }
}
