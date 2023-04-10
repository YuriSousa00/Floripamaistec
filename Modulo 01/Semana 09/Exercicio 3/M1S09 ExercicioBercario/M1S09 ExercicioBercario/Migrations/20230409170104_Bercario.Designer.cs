﻿// <auto-generated />
using System;
using M1S09_ExercicioBercario.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace M1S09_ExercicioBercario.Migrations
{
    [DbContext(typeof(BercarioContext))]
    [Migration("20230409170104_Bercario")]
    partial class Bercario
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("M1S09_ExercicioBercario.Models.Bebe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Altura")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdMae")
                        .HasColumnType("int")
                        .HasColumnName("Id_Mae");

                    b.Property<int>("IdParto")
                        .HasColumnType("int")
                        .HasColumnName("Id_Parto");

                    b.Property<decimal>("PesoNascimento")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("IdMae");

                    b.HasIndex("IdParto");

                    b.ToTable("Bebe", (string)null);
                });

            modelBuilder.Entity("M1S09_ExercicioBercario.Models.Mae", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Mae", (string)null);
                });

            modelBuilder.Entity("M1S09_ExercicioBercario.Models.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CRM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Especialidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Medico", (string)null);
                });

            modelBuilder.Entity("M1S09_ExercicioBercario.Models.Parto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataParto")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HoraParto")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdMedico")
                        .HasColumnType("int")
                        .HasColumnName("Id_Medico");

                    b.HasKey("Id")
                        .HasName("PK_Parto");

                    b.HasIndex("IdMedico");

                    b.ToTable("Parto", (string)null);
                });

            modelBuilder.Entity("M1S09_ExercicioBercario.Models.Bebe", b =>
                {
                    b.HasOne("M1S09_ExercicioBercario.Models.Mae", "Mae")
                        .WithMany("Bebes")
                        .HasForeignKey("IdMae")
                        .IsRequired()
                        .HasConstraintName("FK_Mae_Bebe");

                    b.HasOne("M1S09_ExercicioBercario.Models.Parto", "Parto")
                        .WithMany("Bebes")
                        .HasForeignKey("IdParto")
                        .IsRequired()
                        .HasConstraintName("FK_Parto_Bebe");

                    b.Navigation("Mae");

                    b.Navigation("Parto");
                });

            modelBuilder.Entity("M1S09_ExercicioBercario.Models.Parto", b =>
                {
                    b.HasOne("M1S09_ExercicioBercario.Models.Medico", "Medico")
                        .WithMany("Partos")
                        .HasForeignKey("IdMedico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Parto_Medico");

                    b.Navigation("Medico");
                });

            modelBuilder.Entity("M1S09_ExercicioBercario.Models.Mae", b =>
                {
                    b.Navigation("Bebes");
                });

            modelBuilder.Entity("M1S09_ExercicioBercario.Models.Medico", b =>
                {
                    b.Navigation("Partos");
                });

            modelBuilder.Entity("M1S09_ExercicioBercario.Models.Parto", b =>
                {
                    b.Navigation("Bebes");
                });
#pragma warning restore 612, 618
        }
    }
}
