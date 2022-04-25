using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Djibus.Core.Data.Migrations
{
    public partial class Activities2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Projects_ProjectId",
                table: "Activities");

            migrationBuilder.DropIndex(
                name: "IX_Activities_ProjectId",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Activities");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Activities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Activities_ProjectId",
                table: "Activities",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Projects_ProjectId",
                table: "Activities",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");
        }
    }
}
