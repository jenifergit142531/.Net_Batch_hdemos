using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using week8day3.Models;

namespace week8day3.Models;

public partial class DbfirstContext : DbContext
{
    public DbfirstContext()
    {
    }

    public DbfirstContext(DbContextOptions<DbfirstContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Elecproduct> Elecproducts { get; set; }

    public virtual DbSet<ProductPricing> ProductPricings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=REV-PG02C4Y5;Initial Catalog=dbfirst;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Elecproduct>(entity =>
        {
            entity.HasKey(e => e.Pid).HasName("PK__Elecprod__DD37D91A6D916C28");

            entity.ToTable("Elecproduct");

            entity.Property(e => e.Pid)
                .ValueGeneratedNever()
                .HasColumnName("pid");
            entity.Property(e => e.Brand)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("brand");
            entity.Property(e => e.Pname)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("pname");
        });

        modelBuilder.Entity<ProductPricing>(entity =>
        {
            entity.HasKey(e => e.Billingno).HasName("PK__ProductP__F16B1E7170F4EEEF");

            entity.ToTable("ProductPricing");

            entity.Property(e => e.Billingno).ValueGeneratedNever();
            entity.Property(e => e.Pid).HasColumnName("pid");
            entity.Property(e => e.Pname)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("pname");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.PidNavigation).WithMany(p => p.ProductPricings)
                .HasForeignKey(d => d.Pid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__ProductPric__pid__29572725");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public DbSet<week8day3.Models.Purchase> Purchase { get; set; } = default!;
}
