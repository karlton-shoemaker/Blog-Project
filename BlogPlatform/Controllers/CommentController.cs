using blog_template_practice.Models;
using blog_template_practice.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_template_practice.Controllers
{
    public class CommentController : Controller
    {
        IRepository<Comment> commentRepo;

        public CommentController(IRepository<Comment> commentRepo)
        {
            this.commentRepo = commentRepo;
        }
        public ViewResult Index()
        {
            var commentList = commentRepo.GetAll();

            return View(commentList);
        }

        public ViewResult Create()
        {
            var listOfContents = commentRepo.Contents();

            ViewBag.ContentId = listOfContents;

            return View(new Comment());
        }

        [HttpPost]
        public ActionResult Create(Comment model)
        {
            var listOfContents = commentRepo.Contents();

            ViewBag.ContentId = listOfContents;

            commentRepo.Create(model);

            return RedirectToAction("Index", "Content");
        }
    }
}
