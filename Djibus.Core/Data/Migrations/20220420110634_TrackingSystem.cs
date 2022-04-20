using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Djibus.Core.Data.Migrations
{
    public partial class TrackingSystem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "TypeDemandes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TypeDemandes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TypeDemandes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "TypeDemandes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "TypeDemandes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "PrgCommittees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "PrgCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PrgCommittees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "PrgCommittees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "PrgCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "OrgUnits",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "OrgUnits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "OrgUnits",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "OrgUnits",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrgUnits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "EntrepriseArchitects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "EntrepriseArchitects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "EntrepriseArchitects",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "EntrepriseArchitects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "EntrepriseArchitects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "Developers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Developers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Developers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Developers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Developers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "Demandes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Demandes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Demandes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Demandes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Demandes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "BusinessAnalysts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "BusinessAnalysts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "BusinessAnalysts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "BusinessAnalysts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "BusinessAnalysts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "ArdaCommittees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ArdaCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ArdaCommittees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "ArdaCommittees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "ArdaCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "TypeDemandes");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TypeDemandes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TypeDemandes");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "TypeDemandes");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "TypeDemandes");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "PrgCommittees");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "PrgCommittees");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PrgCommittees");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "PrgCommittees");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "PrgCommittees");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "OrgUnits");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "OrgUnits");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "OrgUnits");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "OrgUnits");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "OrgUnits");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "EntrepriseArchitects");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "EntrepriseArchitects");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "EntrepriseArchitects");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "EntrepriseArchitects");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "EntrepriseArchitects");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Developers");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Developers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Developers");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Developers");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Developers");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Demandes");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Demandes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Demandes");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Demandes");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Demandes");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "BusinessAnalysts");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "BusinessAnalysts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "BusinessAnalysts");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "BusinessAnalysts");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "BusinessAnalysts");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "ArdaCommittees");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ArdaCommittees");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ArdaCommittees");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "ArdaCommittees");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "ArdaCommittees");
        }
    }
}
