using LawyerWbSite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LawyerWbSite.DAL
{
    public class LawyerContext_Test2:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lawyer>().ToTable("TblLawyer");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Lawyer> Lawyers { get; set; }
    }
}