using Microsoft.EntityFrameworkCore.Migrations;

namespace EventsAPI.Migrations
{
    public partial class AtualizacaoNasPropsEvento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Eventos_Generos_GeneroId",
                table: "Eventos");

            migrationBuilder.DropTable(
                name: "Generos");

            migrationBuilder.DropIndex(
                name: "IX_Eventos_GeneroId",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "GeneroId",
                table: "Eventos");

            migrationBuilder.AddColumn<double>(
                name: "ValorIngresso",
                table: "Eventos",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValorIngresso",
                table: "Eventos");

            migrationBuilder.AddColumn<int>(
                name: "GeneroId",
                table: "Eventos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassificacaoIndicativa = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_GeneroId",
                table: "Eventos",
                column: "GeneroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Eventos_Generos_GeneroId",
                table: "Eventos",
                column: "GeneroId",
                principalTable: "Generos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
