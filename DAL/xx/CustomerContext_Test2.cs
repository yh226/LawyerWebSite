using LawyerWbSite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LawyerWbSite.DAL
{
    public class CustomerContext_Test2:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("TblCustomer");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Customer> Customers { get; set; }
    }
}