using ClassicCars.Data.Contexts;
using ClassicCars.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;


namespace ClassicCars.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {

        private ClassicCarsContext db;

        public BlogController(ClassicCarsContext db)
        {
            this.db = db;
        }

        // GET: BlogController
        [HttpGet("Blog")]
        public ActionResult Index()
        {
            var blogs = db.Blogs.OrderBy(b => b.createTime);

            return View(blogs.ToList());
        }


        // GET: BlogController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BlogController/Create
        [HttpPost("Admin/Blog/Create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(include: "Title,Description, Tumbnail")] Blog blog)
        {
            if (ModelState.IsValid)
            {
                blog.createTime = DateTime.Now;
                blog.IsActive = false;

                db.Blogs.Add(blog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(blog);
        }

        // GET: BlogController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Blog blog = db.Blogs.Find(id);
            if (blog == null)
            {
                return RedirectToAction("Index");
            }

            return View(blog);
        }

        // POST: BlogController/Edit/5
        [HttpPost("Admin/Blog/Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(include: "Id,Title,Description, Tumbnail, IsActive, createTime")] Blog blog)
        {
            if (ModelState.IsValid)
            {
                db.Entry(blog).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(blog);
        }

        // GET: BlogController/Delete/5
        public ActionResult Delete(int id)
        {
            Blog blog = db.Blogs.Find(id);

            return View(blog);
        }

        // POST: BlogController/Delete/5
        [HttpPost("Admin/Blog/Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete([Bind(include: "Id,Title,Description, Tumbnail, IsActive")] Blog blog)
        {
            if (ModelState.IsValid)
            {
                db.Blogs.Remove(blog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(blog);
        }
    }
}
