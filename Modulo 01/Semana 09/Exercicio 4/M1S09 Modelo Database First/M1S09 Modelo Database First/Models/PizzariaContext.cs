using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace M1S09_Modelo_Database_First.Models;

public partial class PizzariaContext : DbContext
{
    public PizzariaContext()
    {
    }

    public PizzariaContext(DbContextOptions<PizzariaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Borda> Bordas { get; set; }

    public virtual DbSet<Massa> Massas { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Pizza> Pizzas { get; set; }

    public virtual DbSet<PizzaSabore> PizzaSabores { get; set; }

    public virtual DbSet<Sabore> Sabores { get; set; }

    public virtual DbSet<StatusPizza> StatusPizzas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Borda>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Bordas__3214EC07AA084E04");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOME");
        });

        modelBuilder.Entity<Massa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Massas__3214EC07DA4D124A");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOME");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pedido__3214EC075571F628");

            entity.ToTable("Pedido");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IdPizza)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Id_Pizza");
            entity.Property(e => e.IdStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Id_Status");
        });

        modelBuilder.Entity<Pizza>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pizza__3214EC072A263AE5");

            entity.ToTable("Pizza");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IdBordas)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Id_Bordas");
            entity.Property(e => e.IdMassa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Id_Massa");
        });

        modelBuilder.Entity<PizzaSabore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pizza_Sa__3214EC07B0C18025");

            entity.ToTable("Pizza_Sabores");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IdPizza)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Id_Pizza");
            entity.Property(e => e.IdSabores)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Id_Sabores");
        });

        modelBuilder.Entity<Sabore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Sabores__3214EC07B2809D21");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOME");
        });

        modelBuilder.Entity<StatusPizza>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Status_P__3214EC07613212AC");

            entity.ToTable("Status_Pizza");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOME");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
