using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Djibus.Core.Data.Migrations
{
    public partial class Ajustement2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Demandes_OrgUnits_OrgUnitId",
                table: "Demandes");

            migrationBuilder.AlterColumn<int>(
                name: "OrgUnitId",
                table: "Demandes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Demandes_OrgUnits_OrgUnitId",
                table: "Demandes",
                column: "OrgUnitId",
                principalTable: "OrgUnits",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Demandes_OrgUnits_OrgUnitId",
                table: "Demandes");

            migrationBuilder.AlterColumn<int>(
                name: "OrgUnitId",
                table: "Demandes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Demandes_OrgUnits_OrgUnitId",
                table: "Demandes",
                column: "OrgUnitId",
                principalTable: "OrgUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
