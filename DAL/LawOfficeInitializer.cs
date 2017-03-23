using LawyerWbSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LawyerWbSite.DAL
{
    public class LawOfficeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<LawOfficeContext>
    {
        protected override void Seed(LawOfficeContext context)
        {
            //admin
            var administrators = new List<Administrator>
            {
            new Administrator{AdminID=1,Username="admin",Password="admin"}
            };

            administrators.ForEach(s => context.Administrators.Add(s));
            context.SaveChanges();


            //case
            var cases = new List<Case>
            {
            new Case{CaseID=1,CaseName="aa",Describe="sss",StartDate=DateTime.Parse("2005-09-01"),EndDate=DateTime.Parse("2005-09-01"),LawyerID=1,CustomerID=1}
            };

            cases.ForEach(s => context.Cases.Add(s));
            context.SaveChanges();


            //Customer
            var customers = new List<Customer>
            {
            new Customer{ CustomerID =1,FirstName="Niko",LastName="Han",Phone="02222222",Address="100 silver",Email="aa@g.com",Gender=Gender.Male}
            };

            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();

            //Documnet
            var documnets = new List<Document>
            {
            new Document{ DocumentID =1,DocumentName="NikoFile",DocumentPath="11/11/f.doc",CaseID=1}
            };

            documnets.ForEach(s => context.Documents.Add(s));
            context.SaveChanges();

            //Lawyer
            var lawyers = new List<Lawyer>
            {
            new Lawyer{ LawyerID =1,LastName="NikoLaw",FirstMidName="HanLaw",CaseID=1}
            };

            lawyers.ForEach(s => context.Lawyers.Add(s));
            context.SaveChanges();

        }

    }
}