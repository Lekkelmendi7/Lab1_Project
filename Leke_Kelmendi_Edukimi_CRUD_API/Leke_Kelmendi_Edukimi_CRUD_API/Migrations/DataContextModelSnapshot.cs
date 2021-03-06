// <auto-generated />
using Leke_Kelmendi_Edukimi_CRUD_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Leke_Kelmendi_Edukimi_CRUD_API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Leke_Kelmendi_Edukimi_CRUD_API.Edukimi", b =>
                {
                    b.Property<int>("ID_Puntori")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Puntori"), 1L, 1);

                    b.Property<int>("ECTS")
                        .HasColumnType("int");

                    b.Property<string>("Emri_Puntorit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("GPA")
                        .HasColumnType("float");

                    b.Property<string>("Kolegji")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mbiemri_Puntorit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Niveli_Studimit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VitiFillimit_Studimit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VitiMbarimit_Studimit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_Puntori");

                    b.ToTable("Edukimi");
                });
#pragma warning restore 612, 618
        }
    }
}
