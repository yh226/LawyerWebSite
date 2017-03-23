using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LawyerWbSite.Models
{

    public enum Gender
    {
        Male,Female
    }
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public Gender? Gender { get; set; }
        public int CaseID { get; set; }
        //public virtual Case Case { get; set; }

    }
}