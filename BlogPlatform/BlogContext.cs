using blog_template_practice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_template_practice
{
    public class BlogContext : DbContext
    {
        public DbSet<Content> Contents { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Comment> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=BlogDB_templatetest;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add seed data for Category model:
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "Food",
                    Description = "You know, it's that stuff you eat! People grow stuff, raise livestock, gather fruits and whatnot... then other people market and sell it, you buy it, cook it and then shove it down your mouth-hole. Or eat it raw. Whatever, it's you're body. You know, you are what you eat, so it's basically you."
                },
                new Category()
                {
                    Id = 3,
                    Name = "Video Games",
                    Description = "Modern technology has led to incredible feats of engineering that allow us to experience crazy adventures all from our own homes in the form of video games. Whether puzzles, shooters, adventures, sports, you can do pretty much anything with video games. What will they think of next?"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Movies",
                    Description = "The moving pictures, they were once called. Movies take us on incredible fantastic adventures and let us explore the human psyche through watching beautiful people perfom amazing stories all for our amusement."
                }
                ) ;

            // Add seed data for Content model:
            modelBuilder.Entity<Content>().HasData(
                new Content()
                {
                    Id = 1,
                    Title = "Hotdogs are definitely sandwiches.",
                    Body = "There's bread, and meat in between. What more do you need?!?!?!?!? Get some mustard in there, maybe ketchup if you're frisky, relish or chili, c'mon! Fuhgeddaboutit!!!!",
                    Author = "hotdogluvr_and_chipfnatic",
                    PublishDate = "03/05/21",
                    CategoryId = 1,
                    PostDate = DateTime.Now
                },
                new Content()
                {
                    Id = 2,
                    Title = "Marvel movies are overrated",
                    Body = "Oh the kids these days with their confounded superheroes. Everyone always says \"Oh this one is different, it's new and better than all the others\" but it's not! There's always the implausible origin story, with a tortured too-long build to make them into the superhero we all know they are, and then once you get past that, you have to know who everyone else in the movie is. Who's that robot guy? Why does he live with the redhead? I don't have time to watch all these movies with how many times I mow my lawn. I need something that explains everything all the time. Maybe there should be more subtitles on everything.",
                    Author = "elderlycurmudgeon",
                    PublishDate = "03/05/21",
                    CategoryId = 2,
                    PostDate = DateTime.Now
                },
                new Content()
                {
                    Id = 3,
                    Title = "There are not too many Fire Emblem characters in Smash Bros. Ultimate",
                    Body = "While there are many FE characters in SSBU, the inclusion of all of them is justified. While some are similar, their differences are great enough to warrant separate characters. I won't go into specifics, but we need them all to maintain competitive play. If they do another after Byleth though, that will be too many. Also, instead of Byleth they should have included Claude in order to have an entirely upside-down character or Flayn so that they could have added a fishing mini-game.",
                    Author = "imaimaima_marthboy",
                    PublishDate = "03/05/21",
                    CategoryId = 3,
                    PostDate = DateTime.Now
                }
                ) ;

            modelBuilder.Entity<Comment>().HasData(
                new Comment()
                {
                    Id = 1,
                    Body = "Hot dogs are NOT sandwiches!!!! Why do people keep saying they are?",
                    Author = "sandwich_purist4779",
                    ContentId = 1,
                    PostDate = DateTime.Now
                },
                new Comment()
                {
                    Id = 2,
                    Body = "Okay, this is clearly talking about WandaVision, and that's not even a movie. This dude is whack",
                    Author = "MrStrange",
                    ContentId = 2,
                    PostDate = DateTime.Now
                },
                new Comment()
                {
                    Id = 3,
                    Body = "Ugh, seriously???? We only need one Fire Emblem character. Puke",
                    Author = "kirbymain",
                    ContentId = 3,
                    PostDate = DateTime.Now
                }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
