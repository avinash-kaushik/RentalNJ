using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace corewebapi.Models
{
    public partial class RentalDBContext : DbContext
    {
        public RentalDBContext()
        {
        }

        public RentalDBContext(DbContextOptions<RentalDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AddressDet> AddressDet { get; set; }
        public virtual DbSet<CityDet> CityDet { get; set; }
        public virtual DbSet<CustDet> CustDet { get; set; }
        public virtual DbSet<QuestionsDet> QuestionsDet { get; set; }
        public virtual DbSet<RolesDet> RolesDet { get; set; }
        public virtual DbSet<RolesScreenMap> RolesScreenMap { get; set; }
        public virtual DbSet<ScreenDet> ScreenDet { get; set; }
        public virtual DbSet<SiteDet> SiteDet { get; set; }
        public virtual DbSet<UserDet> UserDet { get; set; }
        public virtual DbSet<UsrRoleMap> UsrRoleMap { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=HIBACL145740;Database=RentalDB;User ID=sanew;password=Password@123;Trusted_Connection=True;");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddressDet>(entity =>
            {
                entity.Property(e => e.AddType).IsUnicode(false);

                entity.Property(e => e.AptNo).IsUnicode(false);

                entity.Property(e => e.BldgNo).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.LeasingOfficeName).IsUnicode(false);

                entity.Property(e => e.State).IsUnicode(false);

                entity.Property(e => e.StreetAddress1).IsUnicode(false);

                entity.Property(e => e.StreetAddress2).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsUnicode(false);

                entity.Property(e => e.Zipcode).IsUnicode(false);

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.AddressDet)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("address_det_site_fk");
            });

            modelBuilder.Entity<CityDet>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.State).IsUnicode(false);

                entity.Property(e => e.Zipcode).IsUnicode(false);

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.CityDet)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("city_det_site_fk");
            });

            modelBuilder.Entity<CustDet>(entity =>
            {
                entity.Property(e => e.AltEmail).IsUnicode(false);

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Fname).IsUnicode(false);

                entity.Property(e => e.Lname).IsUnicode(false);

                entity.Property(e => e.PriTelNo).IsUnicode(false);

                entity.Property(e => e.SecTelNo).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsUnicode(false);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.CustDet)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Cust_Det__Addres__14270015");
            });

            modelBuilder.Entity<QuestionsDet>(entity =>
            {
                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.Desc).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsUnicode(false);
            });

            modelBuilder.Entity<RolesDet>(entity =>
            {
                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.RoleCd).IsUnicode(false);

                entity.Property(e => e.RoleDesc).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsUnicode(false);
            });

            modelBuilder.Entity<RolesScreenMap>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.RoleActIr).IsUnicode(false);

                entity.Property(e => e.RoleCd).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsUnicode(false);
            });

            modelBuilder.Entity<ScreenDet>(entity =>
            {
                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsUnicode(false);
            });

            modelBuilder.Entity<SiteDet>(entity =>
            {
                entity.HasKey(e => e.SiteId)
                    .HasName("PK__Site_Det__E42223CEF09881D1");

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.Desc).IsUnicode(false);

                entity.Property(e => e.State).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsUnicode(false);
            });

            modelBuilder.Entity<UserDet>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.AddressId })
                    .HasName("User_Det_comp_key");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AltEmail).IsUnicode(false);

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Fname).IsUnicode(false);

                entity.Property(e => e.Lname).IsUnicode(false);

                entity.Property(e => e.Passwd).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsUnicode(false);
            });

            modelBuilder.Entity<UsrRoleMap>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.RoleActIr).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
