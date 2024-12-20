using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolidTech.Data.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Projects",
                type: "text",
                maxLength: 2147483647,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldMaxLength: 2147483647);

            migrationBuilder.UpdateData(
                table: "CustomerComments",
                keyColumn: "CustomerCommentId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 20, 19, 35, 59, 359, DateTimeKind.Utc).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "CustomerComments",
                keyColumn: "CustomerCommentId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 20, 19, 35, 59, 359, DateTimeKind.Utc).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 20, 19, 35, 59, 359, DateTimeKind.Utc).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "ProjectCategories",
                keyColumn: "ProjectCategoryId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 20, 19, 35, 59, 359, DateTimeKind.Utc).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "ProjectCategories",
                keyColumn: "ProjectCategoryId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 20, 19, 35, 59, 359, DateTimeKind.Utc).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "ProjectCategories",
                keyColumn: "ProjectCategoryId",
                keyValue: 3,
                column: "CreaDate",
                value: new DateTime(2024, 12, 20, 19, 35, 59, 359, DateTimeKind.Utc).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 20, 19, 35, 59, 359, DateTimeKind.Utc).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 20, 19, 35, 59, 359, DateTimeKind.Utc).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "CreaDate",
                value: new DateTime(2024, 12, 20, 19, 35, 59, 359, DateTimeKind.Utc).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                column: "CreaDate",
                value: new DateTime(2024, 12, 20, 19, 35, 59, 359, DateTimeKind.Utc).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5,
                column: "CreaDate",
                value: new DateTime(2024, 12, 20, 19, 35, 59, 359, DateTimeKind.Utc).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "SolutionId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 20, 19, 35, 59, 359, DateTimeKind.Utc).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "SolutionId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 20, 19, 35, 59, 359, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "SolutionId",
                keyValue: 3,
                column: "CreaDate",
                value: new DateTime(2024, 12, 20, 19, 35, 59, 359, DateTimeKind.Utc).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "TeamMemberId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 20, 19, 35, 59, 359, DateTimeKind.Utc).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "TeamMemberId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 20, 19, 35, 59, 359, DateTimeKind.Utc).AddTicks(8978));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Projects",
                type: "text",
                maxLength: 2147483647,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldMaxLength: 2147483647,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "CustomerComments",
                keyColumn: "CustomerCommentId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 20, 18, 37, 28, 613, DateTimeKind.Utc).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "CustomerComments",
                keyColumn: "CustomerCommentId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 20, 18, 37, 28, 613, DateTimeKind.Utc).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 20, 18, 37, 28, 613, DateTimeKind.Utc).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "ProjectCategories",
                keyColumn: "ProjectCategoryId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 20, 18, 37, 28, 613, DateTimeKind.Utc).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "ProjectCategories",
                keyColumn: "ProjectCategoryId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 20, 18, 37, 28, 613, DateTimeKind.Utc).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "ProjectCategories",
                keyColumn: "ProjectCategoryId",
                keyValue: 3,
                column: "CreaDate",
                value: new DateTime(2024, 12, 20, 18, 37, 28, 613, DateTimeKind.Utc).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 20, 18, 37, 28, 613, DateTimeKind.Utc).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 20, 18, 37, 28, 613, DateTimeKind.Utc).AddTicks(1835));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "CreaDate",
                value: new DateTime(2024, 12, 20, 18, 37, 28, 613, DateTimeKind.Utc).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                column: "CreaDate",
                value: new DateTime(2024, 12, 20, 18, 37, 28, 613, DateTimeKind.Utc).AddTicks(1837));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5,
                column: "CreaDate",
                value: new DateTime(2024, 12, 20, 18, 37, 28, 613, DateTimeKind.Utc).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "SolutionId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 20, 18, 37, 28, 613, DateTimeKind.Utc).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "SolutionId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 20, 18, 37, 28, 613, DateTimeKind.Utc).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "SolutionId",
                keyValue: 3,
                column: "CreaDate",
                value: new DateTime(2024, 12, 20, 18, 37, 28, 613, DateTimeKind.Utc).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "TeamMemberId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 20, 18, 37, 28, 613, DateTimeKind.Utc).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "TeamMemberId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 20, 18, 37, 28, 613, DateTimeKind.Utc).AddTicks(1918));
        }
    }
}
