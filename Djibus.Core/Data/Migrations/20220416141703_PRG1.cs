using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Djibus.Core.Data.Migrations
{
    public partial class PRG1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Demandes_PrgCommittee_PrgCommitteeId",
                table: "Demandes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrgCommittee",
                table: "PrgCommittee");

            migrationBuilder.RenameTable(
                name: "PrgCommittee",
                newName: "PrgCommittees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrgCommittees",
                table: "PrgCommittees",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Demandes_PrgCommittees_PrgCommitteeId",
                table: "Demandes",
                column: "PrgCommitteeId",
                principalTable: "PrgCommittees",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Demandes_PrgCommittees_PrgCommitteeId",
                table: "Demandes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrgCommittees",
                table: "PrgCommittees");

            migrationBuilder.RenameTable(
                name: "PrgCommittees",
                newName: "PrgCommittee");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrgCommittee",
                table: "PrgCommittee",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Demandes_PrgCommittee_PrgCommitteeId",
                table: "Demandes",
                column: "PrgCommitteeId",
                principalTable: "PrgCommittee",
                principalColumn: "Id");
        }
    }
}
