using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Djibus.Core.Data.Migrations
{
    public partial class TypeAndDemande : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrgUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrgUnitName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrgUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeDemandes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DemandeTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeDemandes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Demandes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DemandeTypeId = table.Column<int>(type: "int", nullable: false),
                    TypeDemandeId = table.Column<int>(type: "int", nullable: false),
                    Sponsor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgUnitId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRequestTimeSensitive = table.Column<bool>(type: "bit", nullable: true),
                    BusinessNeed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Benefits = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpectedDeliverables = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfPotentialUsers = table.Column<long>(type: "bigint", nullable: false),
                    IsServiceRequestUnique = table.Column<bool>(type: "bit", nullable: true),
                    ImpactOfNotDoingIt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PotentialSolution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DependenciesIfAny = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demandes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Demandes_OrgUnits_OrgUnitId",
                        column: x => x.OrgUnitId,
                        principalTable: "OrgUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Demandes_TypeDemandes_TypeDemandeId",
                        column: x => x.TypeDemandeId,
                        principalTable: "TypeDemandes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Demandes_OrgUnitId",
                table: "Demandes",
                column: "OrgUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Demandes_TypeDemandeId",
                table: "Demandes",
                column: "TypeDemandeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Demandes");

            migrationBuilder.DropTable(
                name: "OrgUnits");

            migrationBuilder.DropTable(
                name: "TypeDemandes");
        }
    }
}
