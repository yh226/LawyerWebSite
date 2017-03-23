using LawyerWbSite.DAL;
using LawyerWbSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LawyerWbSite.DBL
{
    public class Lawyer_BusinessLayer
    {
        public List<Lawyer> GetLawyers()
        {
            LawyerContext_Test2 db = new LawyerContext_Test2();

            return db.Lawyers.ToList();

        }

        public Lawyer SaveLawyer(Lawyer Myobject)
        {
            LawyerContext_Test2 db = new LawyerContext_Test2();
            db.Lawyers.Add(Myobject);
            db.SaveChanges();
            return Myobject;
        }
    }
}