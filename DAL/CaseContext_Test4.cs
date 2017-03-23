using LawyerWbSite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LawyerWbSite.DAL
{
    public class CaseContext_Test4: DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Case>().ToTable("TblCase");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Case> Cases { get; set; }
        public DbSet<Document> Documents { get; set; }
    }
}