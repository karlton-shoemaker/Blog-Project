using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class CategoryDescriptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Categories",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "You know, it's that stuff you eat! People grow stuff, raise livestock, gather fruits and whatnot... then other people market and sell it, you buy it, cook it and then shove it down your mouth-hole. Or eat it raw. Whatever, it's you're body. You know, you are what you eat, so it's basically you.");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "The moving pictures, they were once called. Movies take us on incredible fantastic adventures and let us explore the human psyche through watching beautiful people perfom amazing stories all for our amusement.");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Modern technology has led to incredible feats of engineering that allow us to experience crazy adventures all from our own homes in the form of video games. Whether puzzles, shooters, adventures, sports, you can do pretty much anything with video games. What will they think of next?");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostDate",
                value: new DateTime(2021, 3, 7, 20, 45, 15, 61, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostDate",
                value: new DateTime(2021, 3, 7, 20, 45, 15, 61, DateTimeKind.Local).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostDate",
                value: new DateTime(2021, 3, 7, 20, 45, 15, 61, DateTimeKind.Local).AddTicks(5890));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Categories");

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
                column: "PostDate",
                value: new DateTime(2021, 3, 7, 20, 36, 59, 697, DateTimeKind.Local).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostDate",
                value: new DateTime(2021, 3, 7, 20, 36, 59, 697, DateTimeKind.Local).AddTicks(9682));
        }
    }
}
