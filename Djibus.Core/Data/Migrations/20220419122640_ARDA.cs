using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Djibus.Core.Data.Migrations
{
    public partial class ARDA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArdaCommitteeId",
                table: "Demandes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ArdaCommittees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateArda = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArdaCommittees", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Demandes_ArdaCommitteeId",
                table: "Demandes",
                column: "ArdaCommitteeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Demandes_ArdaCommittees_ArdaCommitteeId",
                table: "Demandes",
                column: "ArdaCommitteeId",
                principalTable: "ArdaCommittees",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Demandes_ArdaCommittees_ArdaCommitteeId",
                table: "Demandes");

            migrationBuilder.DropTable(
                name: "ArdaCommittees");

            migrationBuilder.DropIndex(
                name: "IX_Demandes_ArdaCommitteeId",
                table: "Demandes");

            migrationBuilder.DropColumn(
                name: "ArdaCommitteeId",
                table: "Demandes");
        }
    }
}
