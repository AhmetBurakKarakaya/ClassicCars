using ClassicCars.Data.Contexts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassicCars.Controllers
{
    public class BlogController : Controller
    {
        private readonly ClassicCarsContext _context;

        public BlogController(ClassicCarsContext context)
        {
            _context = context;
        }
        public IActionResult Blog()
        {
            var blogs = _context.Blogs.Where(b => b.IsActive == true).ToList();
            return View(blogs);
        }

        public IActionResult BlogDetail(int? id)
        {
            var blog = _context.Blogs.FirstOrDefault(b => b.Id == id);
            Console.WriteLine(blog.ToString());
            return View(blog);
        }
    }
}
