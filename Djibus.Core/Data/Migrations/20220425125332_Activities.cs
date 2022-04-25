using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Djibus.Core.Data.Migrations
{
    public partial class Activities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: true),
                    DemandeId = table.Column<int>(type: "int", nullable: true),
                    ActivityDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activities_Demandes_DemandeId",
                        column: x => x.DemandeId,
                        principalTable: "Demandes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Activities_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_DemandeId",
                table: "Activities",
                column: "DemandeId");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_ProjectId",
                table: "Activities",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");
        }
    }
}
