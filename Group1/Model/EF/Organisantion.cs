namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Organisantion")]
    public partial class Organisantion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Organisantion()
        {
            Directorates = new HashSet<Directorate>();
            SupportingMaterials = new HashSet<SupportingMaterial>();
        }

        [Key]
        public int OrgID { get; set; }

        [StringLength(256)]
        public string OrgName { get; set; }

        public int ContactID { get; set; }

        public bool? IsActive { get; set; }

        public virtual Contact Contact { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Directorate> Directorates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupportingMaterial> SupportingMaterials { get; set; }
    }
}
