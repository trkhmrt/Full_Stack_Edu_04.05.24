using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolidTech.Data.Migrations
{
    /// <inheritdoc />
    public partial class Create2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CustomerComments",
                keyColumn: "CustomerCommentId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 30, 19, 59, 43, 968, DateTimeKind.Utc).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "CustomerComments",
                keyColumn: "CustomerCommentId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 30, 19, 59, 43, 968, DateTimeKind.Utc).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 30, 19, 59, 43, 968, DateTimeKind.Utc).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "ProjectCategories",
                keyColumn: "ProjectCategoryId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 30, 19, 59, 43, 968, DateTimeKind.Utc).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "ProjectCategories",
                keyColumn: "ProjectCategoryId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 30, 19, 59, 43, 968, DateTimeKind.Utc).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "ProjectCategories",
                keyColumn: "ProjectCategoryId",
                keyValue: 3,
                column: "CreaDate",
                value: new DateTime(2024, 12, 30, 19, 59, 43, 968, DateTimeKind.Utc).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 30, 19, 59, 43, 968, DateTimeKind.Utc).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 30, 19, 59, 43, 968, DateTimeKind.Utc).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "CreaDate",
                value: new DateTime(2024, 12, 30, 19, 59, 43, 968, DateTimeKind.Utc).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                column: "CreaDate",
                value: new DateTime(2024, 12, 30, 19, 59, 43, 968, DateTimeKind.Utc).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5,
                column: "CreaDate",
                value: new DateTime(2024, 12, 30, 19, 59, 43, 968, DateTimeKind.Utc).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "SolutionId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 30, 19, 59, 43, 968, DateTimeKind.Utc).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "SolutionId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 30, 19, 59, 43, 968, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "SolutionId",
                keyValue: 3,
                column: "CreaDate",
                value: new DateTime(2024, 12, 30, 19, 59, 43, 968, DateTimeKind.Utc).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "TeamMemberId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 30, 19, 59, 43, 968, DateTimeKind.Utc).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "TeamMemberId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 30, 19, 59, 43, 968, DateTimeKind.Utc).AddTicks(4057));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CustomerComments",
                keyColumn: "CustomerCommentId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 30, 19, 39, 41, 604, DateTimeKind.Utc).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "CustomerComments",
                keyColumn: "CustomerCommentId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 30, 19, 39, 41, 604, DateTimeKind.Utc).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 30, 19, 39, 41, 604, DateTimeKind.Utc).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "ProjectCategories",
                keyColumn: "ProjectCategoryId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 30, 19, 39, 41, 604, DateTimeKind.Utc).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "ProjectCategories",
                keyColumn: "ProjectCategoryId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 30, 19, 39, 41, 604, DateTimeKind.Utc).AddTicks(1945));

            migrationBuilder.UpdateData(
                table: "ProjectCategories",
                keyColumn: "ProjectCategoryId",
                keyValue: 3,
                column: "CreaDate",
                value: new DateTime(2024, 12, 30, 19, 39, 41, 604, DateTimeKind.Utc).AddTicks(1946));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 30, 19, 39, 41, 604, DateTimeKind.Utc).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 30, 19, 39, 41, 604, DateTimeKind.Utc).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "CreaDate",
                value: new DateTime(2024, 12, 30, 19, 39, 41, 604, DateTimeKind.Utc).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                column: "CreaDate",
                value: new DateTime(2024, 12, 30, 19, 39, 41, 604, DateTimeKind.Utc).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5,
                column: "CreaDate",
                value: new DateTime(2024, 12, 30, 19, 39, 41, 604, DateTimeKind.Utc).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "SolutionId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 30, 19, 39, 41, 604, DateTimeKind.Utc).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "SolutionId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 30, 19, 39, 41, 604, DateTimeKind.Utc).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "SolutionId",
                keyValue: 3,
                column: "CreaDate",
                value: new DateTime(2024, 12, 30, 19, 39, 41, 604, DateTimeKind.Utc).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "TeamMemberId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 30, 19, 39, 41, 604, DateTimeKind.Utc).AddTicks(2154));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "TeamMemberId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 30, 19, 39, 41, 604, DateTimeKind.Utc).AddTicks(2156));
        }
    }
}
