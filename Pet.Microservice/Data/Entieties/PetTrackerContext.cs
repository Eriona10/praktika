﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Pet.Microservice.Data.Entieties;

public partial class PetTrackerContext : DbContext
{
    public PetTrackerContext()
    {
    }

    public PetTrackerContext(DbContextOptions<PetTrackerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }

    public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }

    public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }

    public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }

    public virtual DbSet<BloodPressure> BloodPressure { get; set; }

    public virtual DbSet<Locations> Locations { get; set; }

    public virtual DbSet<Menu> Menu { get; set; }

    public virtual DbSet<Submenu> Submenu { get; set; }

    public virtual DbSet<Temperature> Temperature { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-Q37P8TE\\SQLEXPRESS;Database=PetTracker;user=eriona;password=123456;MultipleActiveResultSets=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AspNetRoleClaims>(entity =>
        {
            entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaims).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<AspNetRoles>(entity =>
        {
            entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedName] IS NOT NULL)");

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetUserClaims>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserLogins>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserTokens>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.Name).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserTokens).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUsers>(entity =>
        {
            entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

            entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedUserName] IS NOT NULL)");

            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.RoleId).HasMaxLength(450);
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasMany(d => d.Role).WithMany(p => p.User)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRoles",
                    r => r.HasOne<AspNetRoles>().WithMany().HasForeignKey("RoleId"),
                    l => l.HasOne<AspNetUsers>().WithMany().HasForeignKey("UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");
                        j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                    });
        });

        modelBuilder.Entity<BloodPressure>(entity =>
        {
            entity.Property(e => e.DateMeasured).HasColumnType("datetime");
            entity.Property(e => e.DiastolicValue).HasMaxLength(50);
            entity.Property(e => e.SystolicValue).HasMaxLength(50);
        });

        modelBuilder.Entity<Locations>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Location");

            entity.Property(e => e.DataMeaured).HasColumnType("datetime");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Claim)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ClaimType)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Controller)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Icon)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Roles)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.StaysOpenFor)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<Submenu>(entity =>
        {
            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Claim)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ClaimType)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Controller)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Icon)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedFrom)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ParentSubId)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Roles)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.StaysOpenFor)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedFrom)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<Temperature>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DataMeasured).HasColumnType("datetime");
            entity.Property(e => e.Pet).ValueGeneratedOnAdd();
            entity.Property(e => e.Temperature1).HasColumnName("Temperature");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
