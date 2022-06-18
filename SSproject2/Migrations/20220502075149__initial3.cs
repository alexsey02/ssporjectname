using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SSproject2.Migrations
{
    public partial class _initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Applications",
                table: "Applications");

            migrationBuilder.AlterColumn<string>(
                name: "mail",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<Guid>(
                name: "ID",
                table: "Applications",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "AppNumber",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Applications",
                table: "Applications",
                column: "ID");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "6636ad63-fd8b-4214-a6a8-9b85f0690a3c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11546e06-8719-4ad8-b88a-f271ae9d7eab",
                column: "ConcurrencyStamp",
                value: "8e1fe26a-966d-4e73-8336-a030b350ea61");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "6273f638-3775-496e-8988-b093e33035e8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b54472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f16a7f04-28f9-45eb-b942-57f289d369c9", "AQAAAAEAACcQAAAAEAGa03QMshl0+c0PkPcEUsAH9PZ0+t4tG34hyYGznwoRLWOj1TBPEdOBqetdnFcODg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b54472e-4f66-49fa-a20f-e7685b9565d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "00fd4ea7-74a3-42f7-adfe-552ac24a4110", "AQAAAAEAACcQAAAAEJM3/h4wMbkRWpcTwcsSrMRV7GhM5OxBCb1liqC060cCJgToo8jS44qK5wfzHArmFA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b8920b57-b1e4-47bd-b67e-46faa4253faf", "AQAAAAEAACcQAAAAEF4KfcrilclpNBnokm5Wiz8V1VUDbAM0B/qGVt7GesDdN7v+DrSDL/9002oUPUOooQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "ID",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2022, 5, 2, 7, 51, 48, 213, DateTimeKind.Utc).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "ID",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2022, 5, 2, 7, 51, 48, 213, DateTimeKind.Utc).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "ID",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2022, 5, 2, 7, 51, 48, 213, DateTimeKind.Utc).AddTicks(7564));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Applications",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "AppNumber",
                table: "Applications");

            migrationBuilder.AlterColumn<string>(
                name: "mail",
                table: "Applications",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Applications",
                table: "Applications",
                column: "mail");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "da0349bf-7468-4f8b-bf08-32e1ff2dd5e3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11546e06-8719-4ad8-b88a-f271ae9d7eab",
                column: "ConcurrencyStamp",
                value: "b2918cd1-cffb-4ef2-964b-dad0a5b8681d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "ba1c8221-5569-4c0a-bd29-af1caaaf76a2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b54472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ee121f54-1f45-4a09-94e0-0200f0803006", "AQAAAAEAACcQAAAAEDmquDFE7VEhryA/4KPFvNpp3AOP2nTAmzu/xnios5FzKKSMc84bKbq2MoIVKXkRhg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b54472e-4f66-49fa-a20f-e7685b9565d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5f8ae315-ba2c-44f3-b946-240f039a851d", "AQAAAAEAACcQAAAAEBidbN2Kb7ObLKeLkInLf/AXGC+WIhOEhXOguXw9AyCSTBMSlr7lk7xyjnXddrL6/w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f029afb3-3f11-47fc-b45c-a8d563536a7d", "AQAAAAEAACcQAAAAEG/gvxHAenDvviwybuKihH5mXRVT21n8UDbss2z/lrgMv+B3S+h92151Q9+LPMeSCA==" });

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
        }
    }
}
