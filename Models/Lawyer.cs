using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LawyerWbSite.Models
{
    [Table("TblLawyer")]
    public class Lawyer
    {
        [Key]
        public int LawyerID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
       // public virtual ICollection<Case> Cases { get; set; }
    }
}