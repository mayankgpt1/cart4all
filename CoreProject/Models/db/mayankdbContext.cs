using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoreProject.Models.db
{
    public partial class mayankdbContext : DbContext
    {
        public mayankdbContext()
        {
        }

        public mayankdbContext(DbContextOptions<mayankdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActionReason> ActionReason { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Complaints> Complaints { get; set; }
        public virtual DbSet<ComplaintsLog> ComplaintsLog { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<ErrorLog> ErrorLog { get; set; }
        public virtual DbSet<FoodItems> FoodItems { get; set; }
        public virtual DbSet<MealType> MealType { get; set; }
        public virtual DbSet<Menumaster> Menumaster { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<PermissionLog> PermissionLog { get; set; }
        public virtual DbSet<Quality> Quality { get; set; }
        public virtual DbSet<Ratings> Ratings { get; set; }
        public virtual DbSet<Restaurants> Restaurants { get; set; }
        public virtual DbSet<Support> Support { get; set; }
        public virtual DbSet<SupportType> SupportType { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }
        public virtual DbSet<Websites> Websites { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=az1-wsq1.a2hosting.com;Initial Catalog=mayankdb;Integrated Security=False;Persist Security Info=False;User ID=mayank;Password=Welcome@123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "mayank");

            modelBuilder.Entity<ActionReason>(entity =>
            {
                entity.ToTable("ActionReason", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descr)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.LastDateModified).HasColumnType("datetime");
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.ToTable("Categories", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.LastDateModified).HasColumnType("datetime");
            });

            modelBuilder.Entity<Complaints>(entity =>
            {
                entity.ToTable("Complaints", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.LastDateModified).HasColumnType("datetime");
            });

            modelBuilder.Entity<ComplaintsLog>(entity =>
            {
                entity.ToTable("ComplaintsLog", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.LastDateModified).HasColumnType("datetime");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Contact)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Feedback)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.IsDelivered).HasColumnName("isDelivered");

                entity.Property(e => e.LastDateModified).HasColumnType("datetime");
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ErrorLog>(entity =>
            {
                entity.ToTable("ErrorLog", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Browser)
                    .HasColumnName("browser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descr).IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.LastDateModified).HasColumnType("datetime");

                entity.Property(e => e.Os)
                    .HasColumnName("OS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Params)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Weburl)
                    .HasColumnName("weburl")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FoodItems>(entity =>
            {
                entity.ToTable("FoodItems", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descr)
                    .HasColumnName("descr")
                    .HasMaxLength(50);

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.LastDateModified).HasColumnType("datetime");

                entity.Property(e => e.MenuId).HasColumnName("menuId");
            });

            modelBuilder.Entity<MealType>(entity =>
            {
                entity.ToTable("MealType", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descr)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.LastDateModified).HasColumnType("datetime");
            });

            modelBuilder.Entity<Menumaster>(entity =>
            {
                entity.ToTable("menumaster");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Items)
                    .HasColumnName("items")
                    .HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.ToTable("Permission", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.LastDateModified).HasColumnType("datetime");
            });

            modelBuilder.Entity<PermissionLog>(entity =>
            {
                entity.ToTable("PermissionLog", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("createdDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Descr)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Quality>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descr)
                    .HasColumnName("descr")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ratings>(entity =>
            {
                entity.ToTable("Ratings", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descr)
                    .HasColumnName("descr")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.LastDateModified).HasColumnType("datetime");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<Restaurants>(entity =>
            {
                entity.ToTable("Restaurants", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Descr).HasMaxLength(255);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Landline1)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Landline2)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Landline3)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LastDateModified).HasColumnType("datetime");

                entity.Property(e => e.Pincode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Support>(entity =>
            {
                entity.ToTable("Support", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descr)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.LastDateModified).HasColumnType("datetime");
            });

            modelBuilder.Entity<SupportType>(entity =>
            {
                entity.ToTable("SupportType", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descr)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.LastDateModified).HasColumnType("datetime");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AadharCard)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Contact1)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Contact2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Emailid1)
                    .HasColumnName("emailid1")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Emailid2)
                    .HasColumnName("emailid2")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.IsAdmin).HasColumnName("isAdmin");

                entity.Property(e => e.IsClient).HasColumnName("isClient");

                entity.Property(e => e.LastDateModified).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PanCard)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PassCode).HasMaxLength(16);

                entity.Property(e => e.Paytm1)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Paytm2)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.ToTable("UserType", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.LastDateModified).HasColumnType("datetime");

                entity.Property(e => e.Role)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Websites>(entity =>
            {
                entity.ToTable("Websites", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descr).HasMaxLength(100);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.LastDateModified).HasColumnType("datetime");
            });
        }
    }
}
