using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class AddTimeToComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostDate",
                value: new DateTime(2021, 3, 8, 21, 3, 6, 536, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostDate",
                value: new DateTime(2021, 3, 8, 21, 3, 6, 536, DateTimeKind.Local).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostDate",
                value: new DateTime(2021, 3, 8, 21, 3, 6, 536, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostDate",
                value: new DateTime(2021, 3, 8, 21, 3, 6, 535, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostDate",
                value: new DateTime(2021, 3, 8, 21, 3, 6, 535, DateTimeKind.Local).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostDate",
                value: new DateTime(2021, 3, 8, 21, 3, 6, 535, DateTimeKind.Local).AddTicks(2700));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostDate",
                value: new DateTime(2021, 3, 8, 20, 53, 37, 461, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostDate",
                value: new DateTime(2021, 3, 8, 20, 53, 37, 462, DateTimeKind.Local).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostDate",
                value: new DateTime(2021, 3, 8, 20, 53, 37, 462, DateTimeKind.Local).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostDate",
                value: new DateTime(2021, 3, 8, 20, 53, 37, 461, DateTimeKind.Local).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostDate",
                value: new DateTime(2021, 3, 8, 20, 53, 37, 461, DateTimeKind.Local).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostDate",
                value: new DateTime(2021, 3, 8, 20, 53, 37, 461, DateTimeKind.Local).AddTicks(2119));
        }
    }
}
