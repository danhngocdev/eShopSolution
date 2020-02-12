using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                nullable: false,
                defaultValue: new DateTime(2020, 2, 12, 16, 37, 31, 826, DateTimeKind.Local).AddTicks(9854),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 2, 12, 16, 25, 56, 486, DateTimeKind.Local).AddTicks(226));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("69aaede1-57bb-4a90-9ac6-05eaf1999fee"), "b7c41a5b-7d57-47a7-a4e1-1cc97e20c706", "Admin Role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("f7c0ed32-6cb6-40a1-b708-a4c9287ba577"), new Guid("69aaede1-57bb-4a90-9ac6-05eaf1999fee") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("f7c0ed32-6cb6-40a1-b708-a4c9287ba577"), 0, "ee958e77-24fe-4b04-8994-10e66a295911", new DateTime(2020, 2, 12, 16, 37, 31, 864, DateTimeKind.Local).AddTicks(741), "nguyendanhngocndn@gmail.com", true, "Ngoc", "Nguyen Danh", false, null, "nguyendanhngocndn@gmail.com", "admin", "AQAAAAEAACcQAAAAEF3xJK3iVIrpevcnfyAMfmKpEJpq8Yb0zNGuNcyljpChEWUuPvehEGHd4+7FOD8rvg==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 2, 12, 16, 37, 31, 845, DateTimeKind.Local).AddTicks(344));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("69aaede1-57bb-4a90-9ac6-05eaf1999fee"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("f7c0ed32-6cb6-40a1-b708-a4c9287ba577"), new Guid("69aaede1-57bb-4a90-9ac6-05eaf1999fee") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("f7c0ed32-6cb6-40a1-b708-a4c9287ba577"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 2, 12, 16, 25, 56, 486, DateTimeKind.Local).AddTicks(226),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 2, 12, 16, 37, 31, 826, DateTimeKind.Local).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 2, 12, 16, 25, 56, 502, DateTimeKind.Local).AddTicks(4573));
        }
    }
}
