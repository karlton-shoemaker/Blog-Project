using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_template_practice.Models;
using blog_template_practice.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace blog_template_practice.Controllers
{
    public class CategoryController : Controller
    {
        IRepository<Category> categoryRepo;

        public CategoryController(IRepository<Category> categoryRepo)
        {
            this.categoryRepo = categoryRepo;
        }

        public ViewResult Index()
        {
            var categoryList = categoryRepo.GetAll();

            return View(categoryList);
        }

        public ViewResult Details(int id)
        {
            var category = categoryRepo.GetById(id);

            return View(category);
        }

        public ViewResult Create()
        {


            return View(new Category());
        }

        [HttpPost] 
        public ActionResult Create(Category model)
        {
            categoryRepo.Create(model);

            return RedirectToAction("Index");
        }

        public ViewResult Update(int id)
        {
            var category = categoryRepo.GetById(id);

            return View(category);
        }

        [HttpPost]
        public ActionResult Update(Category model)
        {
            categoryRepo.Update(model);

            return RedirectToAction("Index");
        }
    }
}
