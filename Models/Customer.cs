using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LawyerWbSite.Models
{
   
    [Table("TblCustomer")]
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }//  Male,Female
        public string CaseName { get; set; }
        //public virtual Case Case { get; set; }

       

    }
}