using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebService.Models.Generated;

namespace WebService.Data;

public partial class ProFindContext : DbContext
{
    public ProFindContext()
    {
    }

    public ProFindContext(DbContextOptions<ProFindContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Activity> Activities { get; set; } = null!;
    public virtual DbSet<Admin> Admins { get; set; } = null!;
    public virtual DbSet<Client> Clients { get; set; } = null!;
    public virtual DbSet<Department> Departments { get; set; } = null!;
    public virtual DbSet<Notification> Notifications { get; set; } = null!;
    public virtual DbSet<Profession> Professions { get; set; } = null!;
    public virtual DbSet<Professional> Professionals { get; set; } = null!;
    public virtual DbSet<Project> Projects { get; set; } = null!;
    public virtual DbSet<Projectstatus> Projectstatuses { get; set; } = null!;
    public virtual DbSet<Proposal> Proposals { get; set; } = null!;
    public virtual DbSet<Rank> Ranks { get; set; } = null!;
    public virtual DbSet<Tag> Tags { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            optionsBuilder.UseMySql("server=localhost;user=root;database=ProFind", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.27-mysql"));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Activity>(entity =>
        {
            entity.HasKey(e => e.IdA)
                .HasName("PRIMARY");

            entity.Property(e => e.IdA).IsFixedLength();

            entity.Property(e => e.IdPj1).IsFixedLength();

            entity.Property(e => e.IdT1).IsFixedLength();
        });

        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.IdA)
                .HasName("PRIMARY");

            entity.HasIndex(e => new { e.NameA, e.EmailA, e.TelA }, "NameA")
                .HasAnnotation("MySql:FullTextIndex", true);

            entity.Property(e => e.IdA).IsFixedLength();

            entity.Property(e => e.IdR1).IsFixedLength();

            entity.Property(e => e.PasswordA).IsFixedLength();
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.IdC)
                .HasName("PRIMARY");

            entity.Property(e => e.IdC).IsFixedLength();

            entity.Property(e => e.PasswordC).IsFixedLength();
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.IdDp)
                .HasName("PRIMARY");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasKey(e => e.IdN)
                .HasName("PRIMARY");

            entity.Property(e => e.IdN).IsFixedLength();

            entity.Property(e => e.IdPj2).IsFixedLength();
        });

        modelBuilder.Entity<Profession>(entity =>
        {
            entity.HasKey(e => e.IdPfs)
                .HasName("PRIMARY");
        });

        modelBuilder.Entity<Professional>(entity =>
        {
            entity.HasKey(e => e.IdP)
                .HasName("PRIMARY");

            entity.Property(e => e.IdP).IsFixedLength();

            entity.Property(e => e.EmailP).IsFixedLength();

            entity.Property(e => e.NameP).IsFixedLength();

            entity.Property(e => e.PasswordP).IsFixedLength();
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.IdPj)
                .HasName("PRIMARY");

            entity.Property(e => e.IdPj).IsFixedLength();

            entity.Property(e => e.IdC1).IsFixedLength();

            entity.Property(e => e.IdP1).IsFixedLength();
        });

        modelBuilder.Entity<Projectstatus>(entity =>
        {
            entity.HasKey(e => e.IdPs)
                .HasName("PRIMARY");

            entity.Property(e => e.IdPs).IsFixedLength();

            entity.Property(e => e.IdPj3).IsFixedLength();
        });

        modelBuilder.Entity<Proposal>(entity =>
        {
            entity.HasKey(e => e.IdPp)
                .HasName("PRIMARY");

            entity.Property(e => e.IdPp).IsFixedLength();

            entity.Property(e => e.IdC3).IsFixedLength();

            entity.Property(e => e.IdP3).IsFixedLength();
        });

        modelBuilder.Entity<Rank>(entity =>
        {
            entity.HasKey(e => e.IdR)
                .HasName("PRIMARY");
        });

        modelBuilder.Entity<Tag>(entity =>
        {
            entity.HasKey(e => e.IdT)
                .HasName("PRIMARY");

            entity.Property(e => e.IdT).IsFixedLength();

            entity.Property(e => e.IdPj1).IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}