using LawyerWbSite.DAL;
using LawyerWbSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LawyerWbSite.DBL
{
    public class Case_BusinessLayer
    {
        public List<Case> GetCases()
        {
            CaseContext_Test4 db = new CaseContext_Test4();

            return db.Cases.ToList();

        }

        public Case SaveCase(Case c)
        {
            CaseContext_Test4 db = new CaseContext_Test4();
            db.Cases.Add(c);
            db.SaveChanges();
            return c;
        }
    }
}
