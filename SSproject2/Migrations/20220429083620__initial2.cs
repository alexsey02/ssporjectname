using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SSproject2.Migrations
{
    public partial class _initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AppStatus",
                table: "Applications",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "da0349bf-7468-4f8b-bf08-32e1ff2dd5e3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "ba1c8221-5569-4c0a-bd29-af1caaaf76a2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "11546e06-8719-4ad8-b88a-f271ae9d7eab", "b2918cd1-cffb-4ef2-964b-dad0a5b8681d", "curator", "CURATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b54472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ee121f54-1f45-4a09-94e0-0200f0803006", "AQAAAAEAACcQAAAAEDmquDFE7VEhryA/4KPFvNpp3AOP2nTAmzu/xnios5FzKKSMc84bKbq2MoIVKXkRhg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f029afb3-3f11-47fc-b45c-a8d563536a7d", "AQAAAAEAACcQAAAAEG/gvxHAenDvviwybuKihH5mXRVT21n8UDbss2z/lrgMv+B3S+h92151Q9+LPMeSCA==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3b54472e-4f66-49fa-a20f-e7685b9565d9", 0, "5f8ae315-ba2c-44f3-b946-240f039a851d", "curator@mail.com", true, false, null, "CURATOR@mail.com", "CURATOR", "AQAAAAEAACcQAAAAEBidbN2Kb7ObLKeLkInLf/AXGC+WIhOEhXOguXw9AyCSTBMSlr7lk7xyjnXddrL6/w==", null, false, "", false, "curator" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "ID",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2022, 4, 29, 8, 36, 18, 804, DateTimeKind.Utc).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "ID",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2022, 4, 29, 8, 36, 18, 804, DateTimeKind.Utc).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "ID",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2022, 4, 29, 8, 36, 18, 804, DateTimeKind.Utc).AddTicks(8185));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "11546e06-8719-4ad8-b88a-f271ae9d7eab", "3b54472e-4f66-49fa-a20f-e7685b9565d9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "11546e06-8719-4ad8-b88a-f271ae9d7eab", "3b54472e-4f66-49fa-a20f-e7685b9565d9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11546e06-8719-4ad8-b88a-f271ae9d7eab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b54472e-4f66-49fa-a20f-e7685b9565d9");

            migrationBuilder.DropColumn(
                name: "AppStatus",
                table: "Applications");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "9da94d3b-0db5-4c4b-a10c-a4e1e39ea1ec");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "8fc81728-6ad0-43ce-891d-cdb0c66bf7da");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b54472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3d37b228-bd2b-4e0f-9f46-95afe431e451", "AQAAAAEAACcQAAAAEBbrFzMU3SjJO7pxwQLx711sIvzQq2ld/sbS285s1W987jXiZz8w+XfXv1dglPPfoQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "32ab6abc-aa0c-4097-8353-29b7ce56568b", "AQAAAAEAACcQAAAAEOhtyosX5yumRDEpu2Zs/nTci35CPzj48YSTGmzCGT+UMyD67pUTpYVBbH3kLVpEAw==" });

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
        }
    }
}
