namespace LawyerWbSite.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LawyerOfficeModel : DbContext
    {
        public LawyerOfficeModel()
            : base("name=LawyerOfficeContext")
        {
        }

        public virtual DbSet<Administrator> Administrators { get; set; }
        public virtual DbSet<Case> Cases { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<Lawyer> Lawyers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrator>()
                .Property(e => e.Username)
                .IsFixedLength();

            modelBuilder.Entity<Administrator>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<Case>()
                .Property(e => e.CaseName)
                .IsFixedLength();

            modelBuilder.Entity<Case>()
                .Property(e => e.Describe)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.FirstName)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.LastName)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.Address)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.Gender)
                .IsFixedLength();

            modelBuilder.Entity<Document>()
                .Property(e => e.DocumentName)
                .IsFixedLength();

            modelBuilder.Entity<Document>()
                .Property(e => e.DocumentPath)
                .IsFixedLength();

            modelBuilder.Entity<Lawyer>()
                .Property(e => e.LastName)
                .IsFixedLength();

            modelBuilder.Entity<Lawyer>()
                .Property(e => e.FirstName)
                .IsFixedLength();
        }
    }
}
