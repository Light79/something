namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrustDistric")]
    public partial class TrustDistric
    {
        public int TrustDistricID { get; set; }

        [StringLength(256)]
        public string Name { get; set; }

        public string Description { get; set; }

        public int TrustRegionID { get; set; }

        public virtual TrustRegion TrustRegion { get; set; }
    }
}
