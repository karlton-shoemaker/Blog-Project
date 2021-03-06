using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace blog_template_practice.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Display (Name = "Title:")]
        public string Name { get; set; }
        [Display (Name = "Description:")]
        public string Description { get; set; }

        public virtual ICollection<Content> Posts { get; set; }

        public Category()
        {

        }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
