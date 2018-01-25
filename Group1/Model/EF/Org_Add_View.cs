namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Org_Add_View
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrgID { get; set; }

        [StringLength(256)]
        public string OrgName { get; set; }

        [Column("Head Address")]
        [StringLength(770)]
        public string Head_Address { get; set; }

        public int? PostCode { get; set; }

        [StringLength(256)]
        public string Contact { get; set; }

        public bool? IsActive { get; set; }
    }
}
