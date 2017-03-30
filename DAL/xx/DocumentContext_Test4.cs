using LawyerWbSite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LawyerWbSite.DAL
{
    public class DocumentContext_Test4 :DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Document>().ToTable("TblDocument");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Document> Documents { get; set; }
    }
}