using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace IOrange.Data;

public partial class IorangedatabaseContext : DbContext
{
    public IorangedatabaseContext()
    {
    }

    public IorangedatabaseContext(DbContextOptions<IorangedatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bar> Bars { get; set; }

    public virtual DbSet<Efmigrationshistory> Efmigrationshistories { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<Rang> Rangs { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;database=iorangedatabase;uid=root;pwd=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.39-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Bar>(entity =>
        {
            entity.HasKey(e => e.Bid).HasName("PRIMARY");

            entity.ToTable("bar");

            entity.Property(e => e.Bid)
                .ValueGeneratedNever()
                .HasColumnName("BId");
            entity.Property(e => e.Income).HasColumnName("income");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Efmigrationshistory>(entity =>
        {
            entity.HasKey(e => e.MigrationId).HasName("PRIMARY");

            entity.ToTable("__efmigrationshistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PRIMARY");

            entity.ToTable("employee");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("EId");
            entity.Property(e => e.Bid).HasColumnName("BId");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Pid).HasColumnName("PId");
            entity.Property(e => e.Totalincome).HasColumnName("totalincome");
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.Iid).HasName("PRIMARY");

            entity.ToTable("items");

            entity.Property(e => e.Iid)
                .ValueGeneratedNever()
                .HasColumnName("IId");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Sold).HasColumnName("sold");
        });

        modelBuilder.Entity<Rang>(entity =>
        {
            entity.HasKey(e => e.Pid).HasName("PRIMARY");

            entity.ToTable("rangs");

            entity.Property(e => e.Pid)
                .ValueGeneratedNever()
                .HasColumnName("PId");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => e.Tid).HasName("PRIMARY");

            entity.ToTable("transactions");

            entity.Property(e => e.Tid)
                .ValueGeneratedNever()
                .HasColumnName("TId");
            entity.Property(e => e.Bid).HasColumnName("BId");
            entity.Property(e => e.Eid).HasColumnName("EId");
            entity.Property(e => e.Total).HasColumnName("total");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
