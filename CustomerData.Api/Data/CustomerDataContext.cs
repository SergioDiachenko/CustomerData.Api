using CustomerData.Api.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CustomerData.Api.Data
{
    public class CustomerDataContext : DbContext
    {
        public CustomerDataContext()
            : base("CustomerDataConnectionString")
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Transaction>().ToTable("TransactionData");
        }
    }
}