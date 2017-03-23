using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using LawyerWbSite.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace LawyerWbSite.DAL
{
    public class LawyerContext : DbContext
    {
   
        public DbSet<Lawyer> Lawyers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lawyer>().ToTable("TblLawyer");
            base.OnModelCreating(modelBuilder);
        }
    }
}