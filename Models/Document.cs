using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LawyerWbSite.Models
{
    [Table("tblDocument")]
    public class Document
    {
        [Key]
        public int DocumentID { get; set; }
        public string DocumentName { get; set; }
        public string DocumentPath { get; set; }
        public int CaseID { get; set; }

        //public Case Case { get; set; }
     //  public virtual Case Case { get; set; }
    }
}