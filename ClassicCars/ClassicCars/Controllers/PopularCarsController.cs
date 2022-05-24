using ClassicCars.Data.Contexts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassicCars.Controllers
{
    public class PopularCarsController : Controller
    {
        private readonly ClassicCarsContext _context;

        public PopularCarsController(ClassicCarsContext context)
        {
            _context = context;
        }
        public IActionResult PopularCars()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetPopularCars()
        {
            try
            {
                var popularCars = _context.PopularCars.Where(p => p.IsActive == true).OrderBy(p => p.Name).Take(3);
                return Json(new { data = popularCars, Result = true, Message = "OK" });
            }
            catch (Exception e)
            {
                return Json(new { Result = false, Message = e.Message });
            }
        }
    }
}
