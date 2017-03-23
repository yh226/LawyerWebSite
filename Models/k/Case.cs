namespace LawyerWbSite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Case")]
    public partial class Case
    {
        public int CaseID { get; set; }

        [StringLength(100)]
        public string CaseName { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [StringLength(500)]
        public string Describe { get; set; }

        public int? LawyerID { get; set; }

        public int? CustomerID { get; set; }
    }
}
