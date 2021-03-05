using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    PublishDate = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contents_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Food" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Video Games" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Movies" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Author", "Body", "CategoryId", "PublishDate", "Title" },
                values: new object[] { 1, "hotdogluvr_and_chipfnatic", "There's bread, and meat in between. What more do you need?!?!?!?!? Get some mustard in there, maybe ketchup if you're frisky, relish or chili, c'mon! Fuhgeddaboutit!!!!", 1, "03/05/21", "Hotdogs are definitely sandwiches." });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Author", "Body", "CategoryId", "PublishDate", "Title" },
                values: new object[] { 3, "imaimaima_marthboy", "While there are many FE characters in SSBU, the inclusion of all of them is justified. While some are similar, their differences are great enough to warrant separate characters. I won't go into specifics, but we need them all to maintain competitive play. If they do another after Byleth though, that will be too many. Also, instead of Byleth they should have included Claude in order to have an entirely upside-down character or Flayn so that they could have added a fishing mini-game.", 2, "03/05/21", "There are not too many Fire Emblem characters in Smash Bros. Ultimate" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Author", "Body", "CategoryId", "PublishDate", "Title" },
                values: new object[] { 2, "elderlycurmudgeon", "Oh the kids these days with their confounded superheroes. Everyone always says \"Oh this one is different, it's new and better than all the others\" but it's not! There's always the implausible origin story, with a tortured too-long build to make them into the superhero we all know they are, and then once you get past that, you have to know who everyone else in the movie is. Who's that robot guy? Why does he live with the redhead? I don't have time to watch all these movies with how many times I mow my lawn. I need something that explains everything all the time. Maybe there should be more subtitles on everything.", 3, "03/05/21", "Marvel movies are overrated" });

            migrationBuilder.CreateIndex(
                name: "IX_Contents_CategoryId",
                table: "Contents",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contents");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
