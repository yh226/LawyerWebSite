using LawyerWbSite.DAL;
using LawyerWbSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LawyerWbSite.DBL
{
    public class CustomerBusinessLayer
    {
        CustomerContext Customerdb = new CustomerContext();
        public List<Customer> GetCustomers()
        {
            
            return Customerdb.Customers.ToList();
        }

        public Customer SaveCustomers(Customer c)
        {
            // LawOfficeContext lawOfficeContext = new LawOfficeContext();
            Customerdb.Customers.Add(c);
            Customerdb.SaveChanges();

            return c;
        }

    }
}