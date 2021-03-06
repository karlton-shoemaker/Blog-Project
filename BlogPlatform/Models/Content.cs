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

        public int Id { get; set; }
        public string Title { get; set; }
        [Display (Name = "Your opinion")]
        public string Body { get; set; }
        [Display (Name = "Username")]
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
                    author = "Anonymous";
                }
                else
                {
                    author = value;
                }
            }
        }
        public DateTime PostDate { get; set;}
        public string PublishDate { get; set; }

        public int CategoryId { get; set; }
        [Display (Name = "Topic:")]
        public virtual Category Category { get; set; }

        public Content()
        {
            PostDate = DateTime.Now;
        }

        public Content(int id, string title, string body, string author)
        {
            Id = id;
            Title = title;
            Body = body;
            Author = author;
        }

        public Content(int id, string title, string body, string author, string publishDate)
        {
            Id = id;
            Title = title;
            Body = body;
            Author = author;
            PublishDate = publishDate;
        }
    }
}
