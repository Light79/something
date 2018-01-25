namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ManageDbContext : DbContext
    {
        public ManageDbContext()
            : base("name=ManageDbContext")
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<County> Counties { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Directorate> Directorates { get; set; }
        public virtual DbSet<GovOfficeRegion> GovOfficeRegions { get; set; }
        public virtual DbSet<Organisantion> Organisantions { get; set; }
        public virtual DbSet<Premise> Premises { get; set; }
        public virtual DbSet<Programme> Programmes { get; set; }
        public virtual DbSet<ReferenceData> ReferenceDatas { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<SupportingMaterial> SupportingMaterials { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Town> Towns { get; set; }
        public virtual DbSet<TrustDistric> TrustDistrics { get; set; }
        public virtual DbSet<TrustRegion> TrustRegions { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Org_Add_View> Org_Add_View { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .HasMany(e => e.Contacts)
                .WithRequired(e => e.Address)
                .HasForeignKey(e => e.AdressID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .HasMany(e => e.Contact1)
                .WithRequired(e => e.Contact2)
                .HasForeignKey(e => e.ManagerID);

            modelBuilder.Entity<Contact>()
                .HasMany(e => e.Departments)
                .WithRequired(e => e.Contact)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contact>()
                .HasMany(e => e.Directorates)
                .WithRequired(e => e.Contact)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contact>()
                .HasMany(e => e.Organisantions)
                .WithRequired(e => e.Contact)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contact>()
                .HasMany(e => e.Programmes)
                .WithRequired(e => e.Contact)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contact>()
                .HasMany(e => e.Services)
                .WithRequired(e => e.Contact)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contact>()
                .HasMany(e => e.Teams)
                .WithRequired(e => e.Contact)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.CountryName)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Addresses)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Counties)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.GovOfficeRegions)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Towns)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.TrustRegions)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<County>()
                .Property(e => e.CountyName)
                .IsUnicode(false);

            modelBuilder.Entity<County>()
                .HasMany(e => e.Addresses)
                .WithRequired(e => e.County)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<County>()
                .HasMany(e => e.GovOfficeRegions)
                .WithRequired(e => e.County)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<County>()
                .HasMany(e => e.Towns)
                .WithRequired(e => e.County)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Teams)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Directorate>()
                .HasMany(e => e.Departments)
                .WithRequired(e => e.Directorate)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GovOfficeRegion>()
                .Property(e => e.GovOfficeRegionName)
                .IsUnicode(false);

            modelBuilder.Entity<Organisantion>()
                .Property(e => e.OrgName)
                .IsUnicode(false);

            modelBuilder.Entity<Organisantion>()
                .HasMany(e => e.Directorates)
                .WithRequired(e => e.Organisantion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organisantion>()
                .HasMany(e => e.SupportingMaterials)
                .WithRequired(e => e.Organisantion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ReferenceData>()
                .Property(e => e.RefCode)
                .IsUnicode(false);

            modelBuilder.Entity<ReferenceData>()
                .Property(e => e.RefValue)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Service>()
                .HasMany(e => e.Premises)
                .WithRequired(e => e.Service)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Town>()
                .Property(e => e.TownName)
                .IsUnicode(false);

            modelBuilder.Entity<Town>()
                .HasMany(e => e.Addresses)
                .WithRequired(e => e.Town)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TrustDistric>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<TrustDistric>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TrustRegion>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<TrustRegion>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TrustRegion>()
                .HasMany(e => e.TrustDistrics)
                .WithRequired(e => e.TrustRegion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Account)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Role)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.SupportingMaterials)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Org_Add_View>()
                .Property(e => e.OrgName)
                .IsUnicode(false);

            modelBuilder.Entity<Org_Add_View>()
                .Property(e => e.Head_Address)
                .IsUnicode(false);

            modelBuilder.Entity<Org_Add_View>()
                .Property(e => e.Contact)
                .IsUnicode(false);
        }
    }
}
