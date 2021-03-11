using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class PostDateAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "PostDate",
                table: "Contents",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                column: "PostDate",
                value: new DateTime(2021, 3, 6, 15, 3, 24, 988, DateTimeKind.Local).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostDate",
                value: new DateTime(2021, 3, 6, 15, 3, 24, 988, DateTimeKind.Local).AddTicks(6365));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostDate",
                table: "Contents");
        }
    }
}
