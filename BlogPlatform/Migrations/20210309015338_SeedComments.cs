using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class SeedComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Body = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    PostDate = table.Column<DateTime>(nullable: false),
                    ContentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Contents_ContentId",
                        column: x => x.ContentId,
                        principalTable: "Contents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Author", "Body", "ContentId", "PostDate" },
                values: new object[,]
                {
                    { 1, "sandwich_purist4779", "Hot dogs are NOT sandwiches!!!! Why do people keep saying they are?", 1, new DateTime(2021, 3, 8, 20, 53, 37, 461, DateTimeKind.Local).AddTicks(4379) },
                    { 2, "MrStrange", "Okay, this is clearly talking about WandaVision, and that's not even a movie. This dude is whack", 2, new DateTime(2021, 3, 8, 20, 53, 37, 462, DateTimeKind.Local).AddTicks(1125) },
                    { 3, "kirbymain", "Ugh, seriously???? We only need one Fire Emblem character. Puke", 3, new DateTime(2021, 3, 8, 20, 53, 37, 462, DateTimeKind.Local).AddTicks(1305) }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ContentId",
                table: "Comments",
                column: "ContentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

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
    }
}
