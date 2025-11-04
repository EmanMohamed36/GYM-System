using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class ApplySomeChangesToEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MembersBookSessions",
                table: "MembersBookSessions");

            migrationBuilder.DropIndex(
                name: "IX_MembersBookSessions_SessionId",
                table: "MembersBookSessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MembersAssignPlans",
                table: "MembersAssignPlans");

            migrationBuilder.DropIndex(
                name: "IX_MembersAssignPlans_PlanId",
                table: "MembersAssignPlans");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Trainers");

            migrationBuilder.DropColumn(
                name: "MemberSessionId",
                table: "MembersBookSessions");

            migrationBuilder.DropColumn(
                name: "MemberPlanId",
                table: "MembersAssignPlans");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "HealthRecords");

            migrationBuilder.RenameColumn(
                name: "BookingDay",
                table: "MembersBookSessions",
                newName: "BookingDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "MembersBookSessions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "MembersAssignPlans",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "MembersAssignPlans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdate",
                table: "HealthRecords",
                type: "datetime2",
                nullable: false,
                computedColumnSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MembersBookSessions",
                table: "MembersBookSessions",
                columns: new[] { "SessionId", "MemberId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MembersAssignPlans",
                table: "MembersAssignPlans",
                columns: new[] { "PlanId", "MemberId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MembersBookSessions",
                table: "MembersBookSessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MembersAssignPlans",
                table: "MembersAssignPlans");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "MembersBookSessions");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "MembersAssignPlans");

            migrationBuilder.RenameColumn(
                name: "BookingDate",
                table: "MembersBookSessions",
                newName: "BookingDay");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Trainers",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<int>(
                name: "MemberSessionId",
                table: "MembersBookSessions",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "MembersAssignPlans",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<int>(
                name: "MemberPlanId",
                table: "MembersAssignPlans",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Members",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdate",
                table: "HealthRecords",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComputedColumnSql: "GETDATE()");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "HealthRecords",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_MembersBookSessions",
                table: "MembersBookSessions",
                column: "MemberSessionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MembersAssignPlans",
                table: "MembersAssignPlans",
                column: "MemberPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_MembersBookSessions_SessionId",
                table: "MembersBookSessions",
                column: "SessionId");

            migrationBuilder.CreateIndex(
                name: "IX_MembersAssignPlans_PlanId",
                table: "MembersAssignPlans",
                column: "PlanId");
        }
    }
}
