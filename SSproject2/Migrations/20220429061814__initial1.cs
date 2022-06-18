using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SSproject2.Migrations
{
    public partial class _initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TextFields",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    mail = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AppText = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.mail);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "8fc81728-6ad0-43ce-891d-cdb0c66bf7da");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "11546e06-8719-4ad8-b88a-f271ae9d6eab", "9da94d3b-0db5-4c4b-a10c-a4e1e39ea1ec", "otdelsmi", "OTDELSMI" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "32ab6abc-aa0c-4097-8353-29b7ce56568b", "AQAAAAEAACcQAAAAEOhtyosX5yumRDEpu2Zs/nTci35CPzj48YSTGmzCGT+UMyD67pUTpYVBbH3kLVpEAw==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3b54472e-4f66-49fa-a20f-e7685b9565d8", 0, "3d37b228-bd2b-4e0f-9f46-95afe431e451", "otdelsmi@mail.com", true, false, null, "OTDELSMI@mail.com", "OTDELSMI", "AQAAAAEAACcQAAAAEBbrFzMU3SjJO7pxwQLx711sIvzQq2ld/sbS285s1W987jXiZz8w+XfXv1dglPPfoQ==", null, false, "", false, "otdelsmi" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "ID",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2022, 4, 29, 6, 18, 13, 354, DateTimeKind.Utc).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "ID",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2022, 4, 29, 6, 18, 13, 354, DateTimeKind.Utc).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "ID",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2022, 4, 29, 6, 18, 13, 354, DateTimeKind.Utc).AddTicks(4001));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "11546e06-8719-4ad8-b88a-f271ae9d6eab", "3b54472e-4f66-49fa-a20f-e7685b9565d8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "11546e06-8719-4ad8-b88a-f271ae9d6eab", "3b54472e-4f66-49fa-a20f-e7685b9565d8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11546e06-8719-4ad8-b88a-f271ae9d6eab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b54472e-4f66-49fa-a20f-e7685b9565d8");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TextFields",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "a2d16589-91a1-44e8-9311-80b2a7dfaafa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aad21679-5a1c-47fc-a977-f18248379924", "AQAAAAEAACcQAAAAENRsvpQWtxtKDYn4fNRxWvieAgmZUZyRWwAKiLHJRYEPHxe09ivOin5zzdPvD8kHKg==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "ID",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2022, 3, 2, 19, 1, 47, 396, DateTimeKind.Utc).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "ID",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2022, 3, 2, 19, 1, 47, 396, DateTimeKind.Utc).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "ID",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2022, 3, 2, 19, 1, 47, 396, DateTimeKind.Utc).AddTicks(8066));
        }
    }
}
