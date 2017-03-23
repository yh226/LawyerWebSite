using LawyerWbSite.DAL;
using LawyerWbSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LawyerWbSite.DBL
{
    public class Customer_BusinessLayer
    {
        public List<Customer> GetCustomers()
        {
            CustomerContext_Test2 db = new CustomerContext_Test2();

            return db.Customers.ToList();

        }

        public Customer SaveCustomer(Customer Myobject)
        {
            CustomerContext_Test2 db = new CustomerContext_Test2();
            db.Customers.Add(Myobject);
            db.SaveChanges();
            return Myobject;
        }
    }
}