using LawyerWbSite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LawyerWbSite.DAL
{
    public class LawyerOfficeContext_test:DbContext
    {
        public DbSet<Case> Cases { get; set; }
        //public DbSet<Document> Documents { get; set; }
        public DbSet<Lawyer> Lawyers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
    }
}