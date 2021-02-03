using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace corewebapi.Model
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
        public virtual DbSet<Applicants> Applicants { get; set; }
        public virtual DbSet<CityDet> CityDet { get; set; }
        public virtual DbSet<ScreenDet> ScreenDet { get; set; }
        public virtual DbSet<SiteDet> SiteDet { get; set; }
        public virtual DbSet<UserDet> UserDet { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=INDKAL1900740H;Database=RentalDB;Trusted_Connection=True;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddressDet>(entity =>
            {
                entity.ToTable("Address_Det");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BldgNo)
                    .HasColumnName("Bldg_No")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.LeasingOfficeName)
                    .HasColumnName("Leasing_office_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StreetAddress)
                    .HasColumnName("Street_Address")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserDetId).HasColumnName("user_Det_id");

                //entity.HasOne(d => d.City)
                //    .WithMany(p => p.AddressDet)
                //    .HasForeignKey(d => d.CityId)
                //    .HasConstraintName("address_det_city_fk");

                entity.HasOne(d => d.UserDet)
                    .WithOne(p => p.AddressDet)
                    .HasConstraintName("Address_det_user_fk");
            });

            modelBuilder.Entity<Applicants>(entity =>
            {
                entity.Property(e => e.EmailAddress).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(100);
            });

            modelBuilder.Entity<CityDet>(entity =>
            {
                entity.ToTable("city_det");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SiteId).HasColumnName("site_ID");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zipcode)
                    .HasColumnName("zipcode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                //entity.HasOne(d => d.Site)
                //    .WithMany(p => p.CityDet)
                //    .HasForeignKey(d => d.SiteId)
                //    .HasConstraintName("city_det_site_fk");
            });

            modelBuilder.Entity<ScreenDet>(entity =>
            {
                entity.ToTable("Screen_Det");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SiteDet>(entity =>
            {
                entity.HasKey(e => e.SiteId)
                    .HasName("PK__Site_Det__E42223CE61999AF8");

                entity.ToTable("Site_Det");

                entity.Property(e => e.SiteId).HasColumnName("Site_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserDet>(entity =>
            {
                entity.ToTable("User_Det");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Fname)
                    .HasColumnName("fname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .HasColumnName("lname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PriTelNo).HasColumnName("pri_Tel_No");

                entity.Property(e => e.SecTelNo).HasColumnName("Sec_Tel_No");

                entity.Property(e => e.UserTypeId).HasColumnName("user_type_id");

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.UserDet)
                    .HasForeignKey(d => d.UserTypeId)
                    .HasConstraintName("user_det_user_type_fk");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.ToTable("User_Type");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ScreenId).HasColumnName("Screen_ID");

                entity.Property(e => e.Name)
                    .HasColumnName("Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.UserType)
                    .HasForeignKey(d => d.ScreenId)
                    .HasConstraintName("user_type_scrn_fk");
            });

            OnModelCreatingPartial(modelBuilder);

            //modelBuilder.Entity<UserDet>()
            //             .Navigation(b => b.AddressDet)
            //            .UsePropertyAccessMode(PropertyAccessMode.Property);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
