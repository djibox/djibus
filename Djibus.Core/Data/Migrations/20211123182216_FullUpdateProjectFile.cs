using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Djibus.Core.Data.Migrations
{
    public partial class FullUpdateProjectFile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ActualEndDate",
                table: "Projects",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ActualStartDate",
                table: "Projects",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "AllotedBudget",
                table: "Projects",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ApprovedBudget",
                table: "Projects",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "AvailableBudget",
                table: "Projects",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Beneficiary",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ChallengesOrSolutions",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "ChangeManNeeded",
                table: "Projects",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Customer",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Effort",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpectedEndDate",
                table: "Projects",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PM",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "PlannedEndDate",
                table: "Projects",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PlannedStartDate",
                table: "Projects",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PourcentageAchievement",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "ProjectDeliveryDelay",
                table: "Projects",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProjectProcurementIssues",
                table: "Projects",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ProjectStage",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "ProjectsGovernanceIssue",
                table: "Projects",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProjectsRessourcesWithMultiplesAssignement",
                table: "Projects",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProjectsVendorExternalRessources",
                table: "Projects",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RessourceChis1",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ThemeStrategy",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "projectStaffingRessourcesIssues",
                table: "Projects",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "projectUsersAvailabilityIssue",
                table: "Projects",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActualEndDate",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ActualStartDate",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "AllotedBudget",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ApprovedBudget",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "AvailableBudget",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Beneficiary",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ChallengesOrSolutions",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ChangeManNeeded",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Comments",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Customer",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Effort",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ExpectedEndDate",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "PM",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "PlannedEndDate",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "PlannedStartDate",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "PourcentageAchievement",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectDeliveryDelay",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectProcurementIssues",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectStage",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectsGovernanceIssue",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectsRessourcesWithMultiplesAssignement",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectsVendorExternalRessources",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "RessourceChis1",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ThemeStrategy",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "projectStaffingRessourcesIssues",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "projectUsersAvailabilityIssue",
                table: "Projects");
        }
    }
}
