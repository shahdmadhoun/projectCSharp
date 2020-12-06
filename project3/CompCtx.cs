using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace project3
{
    public class CompCtx : DbContext
    {
        public DbSet<Company> Companys { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Produuts { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<TransactionItem> TransactionItems { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=AFNANMADHOUN;Database=comp;Trusted_Connection=True;");
        }
    }
}
