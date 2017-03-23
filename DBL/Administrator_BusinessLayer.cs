using LawyerWbSite.DAL;
using LawyerWbSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LawyerWbSite.DBL
{
    public class Administrator_BusinessLayer
    {
        public List<Administrator> GetAdministrators()
        {
            AdministratorContext db = new AdministratorContext();

            return db.Administrators.ToList();

        }

    }
}