namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Team")]
    public partial class Team
    {
        public int TeamID { get; set; }

        public int DepartmentID { get; set; }

        public int ContactID { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual Department Department { get; set; }
    }
}
