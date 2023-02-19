﻿using Microsoft.EntityFrameworkCore;

namespace StarWarsContext.Models;

public partial class StarWarsContext : DbContext
{
    public StarWarsContext()
    {
    }

    public StarWarsContext(DbContextOptions<StarWarsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<Planet> Planets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            optionsBuilder.UseNpgsql("Name=DefaultConnectionString");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("people_pkey");

            entity.ToTable("people", "base");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BirthYear).HasColumnName("birth_year");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_date");
            entity.Property(e => e.EyeColor).HasColumnName("eye_color");
            entity.Property(e => e.Gender).HasColumnName("gender");
            entity.Property(e => e.HairColor).HasColumnName("hair_color");
            entity.Property(e => e.Height).HasColumnName("height");
            entity.Property(e => e.Mass).HasColumnName("mass");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.PlanetId).HasColumnName("planet_id");
            entity.Property(e => e.SkinColor).HasColumnName("skin_color");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_date");
            entity.Property(e => e.Url).HasColumnName("url");

            entity.HasOne(d => d.Planet).WithMany(p => p.People)
                .HasForeignKey(d => d.PlanetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("people_planet_id_fkey");
        });

        modelBuilder.Entity<Planet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("planet_pkey");

            entity.ToTable("planet", "base");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Climate).HasColumnName("climate");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_date");
            entity.Property(e => e.Diameter).HasColumnName("diameter");
            entity.Property(e => e.Gravity).HasColumnName("gravity");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.OrbitalPeriod).HasColumnName("orbital_period");
            entity.Property(e => e.Population).HasColumnName("population");
            entity.Property(e => e.RotationPeriod).HasColumnName("rotation_period");
            entity.Property(e => e.SurfaceWater).HasColumnName("surface_water");
            entity.Property(e => e.Terrain).HasColumnName("terrain");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_date");
            entity.Property(e => e.Url).HasColumnName("url");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
