using LawyerWbSite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LawyerWbSite.DAL
{
    public class AdministratorContext:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrator>().ToTable("TblAdministrator");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Administrator> Administrators { get; set; }
    }
}