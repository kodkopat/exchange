using Exchange.Domain.Mappings;
using Exchange.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
       : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseInMemoryDatabase("ExchangeDatabase");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new TransactionMapping().BaseMap(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionDetail> TransactionDetail { get; set; }
    }
}
