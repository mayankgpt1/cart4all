using System;
using System.Collections.Generic;
using CoreProject.Models;
using CoreProject.Models.db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoreProject
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

        public virtual DbSet<Menumaster> Menumaster { get; set; }
        public IEnumerable<object> FoodItems { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=az1-wsq1.a2hosting.com;Initial Catalog=mayankdb;Integrated Security=False;Persist Security Info=False;User ID=mayank;Password=Welcome@123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "mayank");

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
            modelBuilder.Entity<FoodItems>(entity =>
            {
                entity.ToTable("fooditems");
                entity.Property(e => e.MenuId).HasColumnName("MenuId");
            });
        }
    }
}
