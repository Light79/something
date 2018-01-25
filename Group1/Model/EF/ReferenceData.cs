namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReferenceData")]
    public partial class ReferenceData
    {
        [Key]
        public int RefID { get; set; }

        [StringLength(256)]
        public string RefCode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RefValue { get; set; }
    }
}
