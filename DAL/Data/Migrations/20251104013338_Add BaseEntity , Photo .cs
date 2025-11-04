using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddBaseEntityPhoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address_Street",
                table: "Trainers",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "Address_City",
                table: "Trainers",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "Address_BuildingNo",
                table: "Trainers",
                newName: "BuildingNo");

            migrationBuilder.RenameColumn(
                name: "Address_Street",
                table: "Members",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "Address_City",
                table: "Members",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "Address_BuildingNo",
                table: "Members",
                newName: "BuildingNo");

            migrationBuilder.RenameColumn(
                name: "HealthRecordId",
                table: "HealthRecords",
                newName: "Id");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Trainers",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Sessions",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Plans",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Members",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Members",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "HealthRecords",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "HealthRecords",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Trainers",
                type: "datetime2",
                nullable: false,
                computedColumnSql: "GETDATE()");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Sessions",
                type: "datetime2",
                nullable: false,
                computedColumnSql: "GETDATE()");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Plans",
                type: "datetime2",
                nullable: false,
                computedColumnSql: "GETDATE()");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Members",
                type: "datetime2",
                nullable: false,
                computedColumnSql: "GETDATE()");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                computedColumnSql: "GETDATE()");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Trainers");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Plans");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Trainers");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Plans");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "HealthRecords");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "HealthRecords");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Trainers",
                newName: "Address_Street");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Trainers",
                newName: "Address_City");

            migrationBuilder.RenameColumn(
                name: "BuildingNo",
                table: "Trainers",
                newName: "Address_BuildingNo");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Members",
                newName: "Address_Street");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Members",
                newName: "Address_City");

            migrationBuilder.RenameColumn(
                name: "BuildingNo",
                table: "Members",
                newName: "Address_BuildingNo");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "HealthRecords",
                newName: "HealthRecordId");
        }
    }
}
