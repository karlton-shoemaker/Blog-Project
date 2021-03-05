﻿using System;
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
            var listOfCategories = contentRepo.Categories();

            ViewBag.CategoryId = new SelectList(listOfCategories, "Id", "Name");

            return View(new Content());
        }

        [HttpPost]
        public ActionResult Create(Content model)
        {
            var listOfCategories = contentRepo.Categories();

            ViewBag.CategoryId = new SelectList(listOfCategories, "Id", "Name");

            contentRepo.Create(model);

            return RedirectToAction("");
        }

        public ViewResult CreateByCategoryId(int id)
        {
            return View();
        }
    }
}
