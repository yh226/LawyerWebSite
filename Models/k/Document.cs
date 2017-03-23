namespace LawyerWbSite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Document")]
    public partial class Document
    {
        public int DocumentID { get; set; }

        [StringLength(50)]
        public string DocumentName { get; set; }

        [StringLength(500)]
        public string DocumentPath { get; set; }

        public int? CaseID { get; set; }
    }
}
