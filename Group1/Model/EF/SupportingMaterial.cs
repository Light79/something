namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SupportingMaterial")]
    public partial class SupportingMaterial
    {
        public int SupportingMaterialID { get; set; }

        public int OrgID { get; set; }

        public int UserID { get; set; }

        public virtual Organisantion Organisantion { get; set; }

        public virtual User User { get; set; }
    }
}
