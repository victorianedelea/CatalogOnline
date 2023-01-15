﻿// <auto-generated />
using System;
using CatalogOnline.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CatalogOnline.Migrations
{
    [DbContext(typeof(CatalogOnlineContext))]
    [Migration("20230115002521_ListaPM")]
    partial class ListaPM
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CatalogOnline.Models.ListaProfesoriMaterie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("MaterieID")
                        .HasColumnType("int");

                    b.Property<int?>("ProfesorID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MaterieID");

                    b.HasIndex("ProfesorID");

                    b.ToTable("ListaProfesoriMaterie");
                });

            modelBuilder.Entity("CatalogOnline.Models.Materie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("NumeMaterie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Materie");
                });

            modelBuilder.Entity("CatalogOnline.Models.Profesor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Facultate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeProfesor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Profesor");
                });

            modelBuilder.Entity("CatalogOnline.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<decimal>("An")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Facultate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MaterieID")
                        .HasColumnType("int");

                    b.Property<string>("NumeStudent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("MaterieID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("CatalogOnline.Models.ListaProfesoriMaterie", b =>
                {
                    b.HasOne("CatalogOnline.Models.Materie", "Materie")
                        .WithMany()
                        .HasForeignKey("MaterieID");

                    b.HasOne("CatalogOnline.Models.Profesor", "Profesor")
                        .WithMany()
                        .HasForeignKey("ProfesorID");

                    b.Navigation("Materie");

                    b.Navigation("Profesor");
                });

            modelBuilder.Entity("CatalogOnline.Models.Student", b =>
                {
                    b.HasOne("CatalogOnline.Models.Materie", null)
                        .WithMany("Studenti")
                        .HasForeignKey("MaterieID");
                });

            modelBuilder.Entity("CatalogOnline.Models.Materie", b =>
                {
                    b.Navigation("Studenti");
                });
#pragma warning restore 612, 618
        }
    }
}
