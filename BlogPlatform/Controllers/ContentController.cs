using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_template_practice.Models;
using blog_template_practice.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace blog_template_practice.Controllers
{
    public class ContentController : Controller
    {
        IRepository<Content> contentRepo;

        public void SetupCategoryViewBag()
        {
            var listOfCategories = contentRepo.Categories();

            ViewBag.CategoryId = listOfCategories;
        }

        public ContentController(IRepository<Content> contentRepo)
        {
            this.contentRepo = contentRepo;
        }

        public ViewResult Index()
        {
            var postList = contentRepo.GetAll();

            return View(postList);
        }

        public ViewResult Details(int id)
        {
            var post = contentRepo.GetById(id);

            return View(post);
        }

        public ViewResult Create()
        {
            SetupCategoryViewBag();

            return View(new Content());
        }

        [HttpPost]
        public ActionResult Create(Content model)
        {
            SetupCategoryViewBag();

            contentRepo.Create(model);

            return RedirectToAction("Index", "Category");
        }

        public ViewResult CreateByCategoryId(int id)
        {
            return View();
        }

        public ViewResult Delete(int id)
        {
            var post = contentRepo.GetById(id);

            return View(post);
        }

        [HttpPost]
        public ActionResult Delete(Content model)
        {
            contentRepo.Delete(model);

            return RedirectToAction("Index", "Category");
        }

        public ViewResult Update(int id)
        {
            SetupCategoryViewBag();

            var post = contentRepo.GetById(id);

            return View(post);
        }

        [HttpPost]
        public ActionResult Update(Content model)
        {
            contentRepo.Update(model);

            return RedirectToAction("Index", "Category");
        }
    }
}
