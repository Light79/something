namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GovOfficeRegion")]
    public partial class GovOfficeRegion
    {
        public int GovOfficeRegionID { get; set; }

        [StringLength(256)]
        public string GovOfficeRegionName { get; set; }

        public int CountyID { get; set; }

        public int CountryID { get; set; }

        public virtual Country Country { get; set; }

        public virtual County County { get; set; }
    }
}
