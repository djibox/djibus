using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Djibus.Core.Data.Migrations
{
    public partial class DevBAEA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BusinessAnalystId",
                table: "Demandes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeveloperId",
                table: "Demandes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EntrepriseArchitectId",
                table: "Demandes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BusinessAnalysts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessAnalysts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Developers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Developers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntrepriseArchitects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntrepriseArchitects", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Demandes_BusinessAnalystId",
                table: "Demandes",
                column: "BusinessAnalystId");

            migrationBuilder.CreateIndex(
                name: "IX_Demandes_DeveloperId",
                table: "Demandes",
                column: "DeveloperId");

            migrationBuilder.CreateIndex(
                name: "IX_Demandes_EntrepriseArchitectId",
                table: "Demandes",
                column: "EntrepriseArchitectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Demandes_BusinessAnalysts_BusinessAnalystId",
                table: "Demandes",
                column: "BusinessAnalystId",
                principalTable: "BusinessAnalysts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Demandes_Developers_DeveloperId",
                table: "Demandes",
                column: "DeveloperId",
                principalTable: "Developers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Demandes_EntrepriseArchitects_EntrepriseArchitectId",
                table: "Demandes",
                column: "EntrepriseArchitectId",
                principalTable: "EntrepriseArchitects",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Demandes_BusinessAnalysts_BusinessAnalystId",
                table: "Demandes");

            migrationBuilder.DropForeignKey(
                name: "FK_Demandes_Developers_DeveloperId",
                table: "Demandes");

            migrationBuilder.DropForeignKey(
                name: "FK_Demandes_EntrepriseArchitects_EntrepriseArchitectId",
                table: "Demandes");

            migrationBuilder.DropTable(
                name: "BusinessAnalysts");

            migrationBuilder.DropTable(
                name: "Developers");

            migrationBuilder.DropTable(
                name: "EntrepriseArchitects");

            migrationBuilder.DropIndex(
                name: "IX_Demandes_BusinessAnalystId",
                table: "Demandes");

            migrationBuilder.DropIndex(
                name: "IX_Demandes_DeveloperId",
                table: "Demandes");

            migrationBuilder.DropIndex(
                name: "IX_Demandes_EntrepriseArchitectId",
                table: "Demandes");

            migrationBuilder.DropColumn(
                name: "BusinessAnalystId",
                table: "Demandes");

            migrationBuilder.DropColumn(
                name: "DeveloperId",
                table: "Demandes");

            migrationBuilder.DropColumn(
                name: "EntrepriseArchitectId",
                table: "Demandes");
        }
    }
}
