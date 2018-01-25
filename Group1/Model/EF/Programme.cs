namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Programme")]
    public partial class Programme
    {
        public int ProgrammeID { get; set; }

        public int ContactID { get; set; }

        public virtual Contact Contact { get; set; }
    }
}
