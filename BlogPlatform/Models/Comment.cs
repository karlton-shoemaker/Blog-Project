using blog_template_practice.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blog_template_practice.Models
{
    public class Comment
    {
        private string author;
        private string body;

        public int Id { get; set; }
        [Display(Name = "Your opinion:")]
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
                    body = "(no comment)";
                }
                else
                {
                    body = value;
                }
            }
        }
        [Display(Name = "Username:")]
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
                    author = "Anonymous" + Content.RandomFood() + Content.RandomNumberAsString();
                }
                else
                {
                    author = value;
                }
            }
        }
        [Display(Name = "Date Posted:")]
        public DateTime PostDate { get; set; }

        public int ContentId { get; set; }
        public virtual Content Content { get; set; }

        public Comment()
        {
            PostDate = DateTime.Now;
        }
    }
}
