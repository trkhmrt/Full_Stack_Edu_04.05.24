using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SolidTech.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    username = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.UpdateData(
                table: "CustomerComments",
                keyColumn: "CustomerCommentId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 9, 17, 23, 59, 428, DateTimeKind.Utc).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "CustomerComments",
                keyColumn: "CustomerCommentId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 9, 17, 23, 59, 428, DateTimeKind.Utc).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 9, 17, 23, 59, 428, DateTimeKind.Utc).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "ProjectCategories",
                keyColumn: "ProjectCategoryId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 9, 17, 23, 59, 428, DateTimeKind.Utc).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "ProjectCategories",
                keyColumn: "ProjectCategoryId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 9, 17, 23, 59, 428, DateTimeKind.Utc).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "ProjectCategories",
                keyColumn: "ProjectCategoryId",
                keyValue: 3,
                column: "CreaDate",
                value: new DateTime(2024, 12, 9, 17, 23, 59, 428, DateTimeKind.Utc).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 9, 17, 23, 59, 428, DateTimeKind.Utc).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 9, 17, 23, 59, 428, DateTimeKind.Utc).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "CreaDate",
                value: new DateTime(2024, 12, 9, 17, 23, 59, 428, DateTimeKind.Utc).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                column: "CreaDate",
                value: new DateTime(2024, 12, 9, 17, 23, 59, 428, DateTimeKind.Utc).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5,
                column: "CreaDate",
                value: new DateTime(2024, 12, 9, 17, 23, 59, 428, DateTimeKind.Utc).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "SolutionId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 9, 17, 23, 59, 428, DateTimeKind.Utc).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "SolutionId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 9, 17, 23, 59, 428, DateTimeKind.Utc).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "SolutionId",
                keyValue: 3,
                column: "CreaDate",
                value: new DateTime(2024, 12, 9, 17, 23, 59, 428, DateTimeKind.Utc).AddTicks(955));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "TeamMemberId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 9, 17, 23, 59, 428, DateTimeKind.Utc).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "TeamMemberId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 9, 17, 23, 59, 428, DateTimeKind.Utc).AddTicks(983));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "CustomerComments",
                keyColumn: "CustomerCommentId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 9, 17, 11, 29, 253, DateTimeKind.Utc).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "CustomerComments",
                keyColumn: "CustomerCommentId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 9, 17, 11, 29, 253, DateTimeKind.Utc).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 9, 17, 11, 29, 253, DateTimeKind.Utc).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "ProjectCategories",
                keyColumn: "ProjectCategoryId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 9, 17, 11, 29, 253, DateTimeKind.Utc).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "ProjectCategories",
                keyColumn: "ProjectCategoryId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 9, 17, 11, 29, 253, DateTimeKind.Utc).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "ProjectCategories",
                keyColumn: "ProjectCategoryId",
                keyValue: 3,
                column: "CreaDate",
                value: new DateTime(2024, 12, 9, 17, 11, 29, 253, DateTimeKind.Utc).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 9, 17, 11, 29, 253, DateTimeKind.Utc).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 9, 17, 11, 29, 253, DateTimeKind.Utc).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "CreaDate",
                value: new DateTime(2024, 12, 9, 17, 11, 29, 253, DateTimeKind.Utc).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                column: "CreaDate",
                value: new DateTime(2024, 12, 9, 17, 11, 29, 253, DateTimeKind.Utc).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5,
                column: "CreaDate",
                value: new DateTime(2024, 12, 9, 17, 11, 29, 253, DateTimeKind.Utc).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "SolutionId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 9, 17, 11, 29, 253, DateTimeKind.Utc).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "SolutionId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 9, 17, 11, 29, 253, DateTimeKind.Utc).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "SolutionId",
                keyValue: 3,
                column: "CreaDate",
                value: new DateTime(2024, 12, 9, 17, 11, 29, 253, DateTimeKind.Utc).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "TeamMemberId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 9, 17, 11, 29, 253, DateTimeKind.Utc).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "TeamMemberId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 9, 17, 11, 29, 253, DateTimeKind.Utc).AddTicks(5729));
        }
    }
}
