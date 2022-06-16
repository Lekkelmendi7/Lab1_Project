using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leke_Kelmendi_Edukimi_CRUD_API.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Edukimi",
                columns: table => new
                {
                    ID_Puntori = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emri_Puntorit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mbiemri_Puntorit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kolegji = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VitiFillimit_Studimit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VitiMbarimit_Studimit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Niveli_Studimit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ECTS = table.Column<int>(type: "int", nullable: false),
                    GPA = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Edukimi", x => x.ID_Puntori);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Edukimi");
        }
    }
}
