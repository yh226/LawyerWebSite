using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LawyerWbSite.Models
{
    [Table("TblCase")]
    public class Case
    {
        [Key]
        public int CaseID { get; set; }
        public string CaseName { get; set; }
        public string Describe { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }
        public string LawyerName { get; set; }
        public string CustomerName { get; set; }

        //public List<Document> Documents { get; set; }
        //public virtual ICollection<Document> Documents { get; set; }
        //public virtual Customer Customer { get; set; }

    }
}