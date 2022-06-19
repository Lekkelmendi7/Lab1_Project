using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leke_Kelmendi_Kontrata_CRUD.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kontrata",
                columns: table => new
                {
                    ID_Puntori = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emri_Puntorit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mbiemri_Puntorit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kompania = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pozita_Punes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pronari_Kompanise = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kohezgjatja_Kontrates = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kontrata", x => x.ID_Puntori);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kontrata");
        }
    }
}
