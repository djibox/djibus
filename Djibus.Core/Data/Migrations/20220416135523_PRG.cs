using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Djibus.Core.Data.Migrations
{
    public partial class PRG : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PrgCommitteeId",
                table: "Demandes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PrgCommittee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatePRG = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrgCommittee", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Demandes_PrgCommitteeId",
                table: "Demandes",
                column: "PrgCommitteeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Demandes_PrgCommittee_PrgCommitteeId",
                table: "Demandes",
                column: "PrgCommitteeId",
                principalTable: "PrgCommittee",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Demandes_PrgCommittee_PrgCommitteeId",
                table: "Demandes");

            migrationBuilder.DropTable(
                name: "PrgCommittee");

            migrationBuilder.DropIndex(
                name: "IX_Demandes_PrgCommitteeId",
                table: "Demandes");

            migrationBuilder.DropColumn(
                name: "PrgCommitteeId",
                table: "Demandes");
        }
    }
}
