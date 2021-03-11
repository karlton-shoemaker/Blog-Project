using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class FixedPostIDs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostDate",
                value: new DateTime(2021, 3, 7, 20, 36, 59, 697, DateTimeKind.Local).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "PostDate" },
                values: new object[] { 2, new DateTime(2021, 3, 7, 20, 36, 59, 697, DateTimeKind.Local).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "PostDate" },
                values: new object[] { 3, new DateTime(2021, 3, 7, 20, 36, 59, 697, DateTimeKind.Local).AddTicks(9682) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostDate",
                value: new DateTime(2021, 3, 6, 15, 3, 24, 984, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "PostDate" },
                values: new object[] { 3, new DateTime(2021, 3, 6, 15, 3, 24, 988, DateTimeKind.Local).AddTicks(6310) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "PostDate" },
                values: new object[] { 2, new DateTime(2021, 3, 6, 15, 3, 24, 988, DateTimeKind.Local).AddTicks(6365) });
        }
    }
}
