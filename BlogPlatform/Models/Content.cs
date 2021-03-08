using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blog_template_practice.Models
{
    public class Content
    {
        private string author;
        private string title;
        private string body;

        public int Id { get; set; }
        [Display (Name = "Title:")]
        public string Title 
        {
            get
            {
                return title;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    title = "(untitled)";
                }
                else
                {
                    title = value;
                }
            }
        }
        [Display (Name = "Your opinion:")]
        public string Body 
        {
            get
            {
                return body;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    body = "(no opinion, man)";
                }
                else
                {
                    body = value;
                }
            }
        }
        [Display (Name = "Username:")]
        public string Author 
        {
            get
            {
                return author;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    author = "Anonymous" + RandomFood() + RandomNumberAsString();
                }
                else
                {
                    author = value;
                }
            }
        }
        [Display (Name = "Date Posted:")]
        public DateTime PostDate { get; set;}
        public string PublishDate { get; set; }

        public int CategoryId { get; set; }
        [Display (Name = "Topic:")]
        public virtual Category Category { get; set; }

        public Content()
        {
            PostDate = DateTime.Now;
        }

        public Content(int id, string title, string body, string author, string publishDate)
        {
            Id = id;
            Title = title;
            Body = body;
            Author = author;
            PublishDate = publishDate;
        }

        public string RandomFood()
        {
            List<string> foodItems = new List<string>()
            {
                "Taco","Burrito","Pancakes","Burger","FrenchFry","Apple","Pizza","Pineapple","Bratwurst","Pretzel","Crepe","Donut","Beignet","Carrot","PotRoast","Mushroom","Ham","ChickenBreast","Schnitzel","Falafel"
            };
            int numberOfFood = foodItems.Count;

            Random random = new Random();
            int listIndex = random.Next(numberOfFood);

            return foodItems[listIndex];
        }

        public string RandomNumberAsString()
        {
            Random random = new Random();
            return Convert.ToString(random.Next(101));
        }
    }
}
