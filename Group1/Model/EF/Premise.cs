namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Premise")]
    public partial class Premise
    {
        public int PremiseID { get; set; }

        public int ServiceID { get; set; }

        public virtual Service Service { get; set; }
    }
}
