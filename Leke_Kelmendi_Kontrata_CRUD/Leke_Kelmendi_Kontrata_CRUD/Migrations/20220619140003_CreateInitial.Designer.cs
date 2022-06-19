﻿// <auto-generated />
using Leke_Kelmendi_Kontrata_CRUD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Leke_Kelmendi_Kontrata_CRUD.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220619140003_CreateInitial")]
    partial class CreateInitial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Leke_Kelmendi_Kontrata_CRUD.Kontrata", b =>
                {
                    b.Property<int>("ID_Puntori")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Puntori"), 1L, 1);

                    b.Property<string>("Emri_Puntorit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kohezgjatja_Kontrates")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kompania")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mbiemri_Puntorit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pozita_Punes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pronari_Kompanise")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_Puntori");

                    b.ToTable("Kontrata");
                });
#pragma warning restore 612, 618
        }
    }
}
