using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SolidTech.Data.Migrations
{
    /// <inheritdoc />
    public partial class MessageTypeAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SendingMessageLog");

            migrationBuilder.AddColumn<int>(
                name: "MessageTypeId",
                table: "Messages",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MessageTypes",
                columns: table => new
                {
                    MessageTypeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MessageTypeName = table.Column<string>(type: "text", nullable: false),
                    MessageTypeDescription = table.Column<string>(type: "text", nullable: false),
                    CreaDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageTypes", x => x.MessageTypeId);
                });

            migrationBuilder.UpdateData(
                table: "CustomerComments",
                keyColumn: "CustomerCommentId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 18, 17, 26, 3, 701, DateTimeKind.Utc).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "CustomerComments",
                keyColumn: "CustomerCommentId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 18, 17, 26, 3, 701, DateTimeKind.Utc).AddTicks(2175));

            migrationBuilder.InsertData(
                table: "MessageTypes",
                columns: new[] { "MessageTypeId", "CreaDate", "IsDeleted", "MessageTypeDescription", "MessageTypeName" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Gelen Kutusu Mesajları(Kullanıcı)", "inbox" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Giden Kutusu Mesajları(Kullanıcı)", "sentbox" }
                });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                columns: new[] { "CreaDate", "MessageTypeId" },
                values: new object[] { new DateTime(2024, 12, 18, 17, 26, 3, 701, DateTimeKind.Utc).AddTicks(2196), null });

            migrationBuilder.UpdateData(
                table: "ProjectCategories",
                keyColumn: "ProjectCategoryId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 18, 17, 26, 3, 701, DateTimeKind.Utc).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "ProjectCategories",
                keyColumn: "ProjectCategoryId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 18, 17, 26, 3, 701, DateTimeKind.Utc).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "ProjectCategories",
                keyColumn: "ProjectCategoryId",
                keyValue: 3,
                column: "CreaDate",
                value: new DateTime(2024, 12, 18, 17, 26, 3, 701, DateTimeKind.Utc).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 18, 17, 26, 3, 701, DateTimeKind.Utc).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 18, 17, 26, 3, 701, DateTimeKind.Utc).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "CreaDate",
                value: new DateTime(2024, 12, 18, 17, 26, 3, 701, DateTimeKind.Utc).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                column: "CreaDate",
                value: new DateTime(2024, 12, 18, 17, 26, 3, 701, DateTimeKind.Utc).AddTicks(2097));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5,
                column: "CreaDate",
                value: new DateTime(2024, 12, 18, 17, 26, 3, 701, DateTimeKind.Utc).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "SolutionId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 18, 17, 26, 3, 701, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "SolutionId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 18, 17, 26, 3, 701, DateTimeKind.Utc).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "SolutionId",
                keyValue: 3,
                column: "CreaDate",
                value: new DateTime(2024, 12, 18, 17, 26, 3, 701, DateTimeKind.Utc).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "TeamMemberId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 18, 17, 26, 3, 701, DateTimeKind.Utc).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "TeamMemberId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 18, 17, 26, 3, 701, DateTimeKind.Utc).AddTicks(2149));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MessageTypes");

            migrationBuilder.DropColumn(
                name: "MessageTypeId",
                table: "Messages");

            migrationBuilder.CreateTable(
                name: "SendingMessageLog",
                columns: table => new
                {
                    SendingMessageId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreaDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    MessageContent = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    MessageHeader = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    SendToEmail = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SendingMessageLog", x => x.SendingMessageId);
                });

            migrationBuilder.UpdateData(
                table: "CustomerComments",
                keyColumn: "CustomerCommentId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 18, 17, 21, 23, 36, DateTimeKind.Utc).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "CustomerComments",
                keyColumn: "CustomerCommentId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 18, 17, 21, 23, 36, DateTimeKind.Utc).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 18, 17, 21, 23, 36, DateTimeKind.Utc).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "ProjectCategories",
                keyColumn: "ProjectCategoryId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 18, 17, 21, 23, 36, DateTimeKind.Utc).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "ProjectCategories",
                keyColumn: "ProjectCategoryId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 18, 17, 21, 23, 36, DateTimeKind.Utc).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "ProjectCategories",
                keyColumn: "ProjectCategoryId",
                keyValue: 3,
                column: "CreaDate",
                value: new DateTime(2024, 12, 18, 17, 21, 23, 36, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 18, 17, 21, 23, 36, DateTimeKind.Utc).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 18, 17, 21, 23, 36, DateTimeKind.Utc).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "CreaDate",
                value: new DateTime(2024, 12, 18, 17, 21, 23, 36, DateTimeKind.Utc).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                column: "CreaDate",
                value: new DateTime(2024, 12, 18, 17, 21, 23, 36, DateTimeKind.Utc).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5,
                column: "CreaDate",
                value: new DateTime(2024, 12, 18, 17, 21, 23, 36, DateTimeKind.Utc).AddTicks(946));

            migrationBuilder.InsertData(
                table: "SendingMessageLog",
                columns: new[] { "SendingMessageId", "CreaDate", "IsDeleted", "MessageContent", "MessageHeader", "SendToEmail" },
                values: new object[] { 1, new DateTime(2024, 12, 18, 17, 21, 23, 36, DateTimeKind.Utc).AddTicks(1088), false, "İnternet Bağlantınız zayıf", "İnternet Bağlantısı", "tugcetoker@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "SolutionId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 18, 17, 21, 23, 36, DateTimeKind.Utc).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "SolutionId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 18, 17, 21, 23, 36, DateTimeKind.Utc).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "Solutions",
                keyColumn: "SolutionId",
                keyValue: 3,
                column: "CreaDate",
                value: new DateTime(2024, 12, 18, 17, 21, 23, 36, DateTimeKind.Utc).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "TeamMemberId",
                keyValue: 1,
                column: "CreaDate",
                value: new DateTime(2024, 12, 18, 17, 21, 23, 36, DateTimeKind.Utc).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "TeamMemberId",
                keyValue: 2,
                column: "CreaDate",
                value: new DateTime(2024, 12, 18, 17, 21, 23, 36, DateTimeKind.Utc).AddTicks(998));
        }
    }
}
