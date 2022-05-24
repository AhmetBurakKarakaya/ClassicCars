using ClassicCars.Data.Contexts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassicCars.Controllers
{
    public class HeadCarsController : Controller
    {
        private readonly ClassicCarsContext _context;

        public HeadCarsController(ClassicCarsContext context)
        {
            _context = context;
        }

        
        public IActionResult HeadCars()
        {
            return View(); 
        }

        [HttpPost]
        public JsonResult GetHeadCars()
        {
            try
            {
                var headCars = _context.HeadCars.Where(h => h.IsActive == true).OrderBy(h => h.Id);
                return Json(new { data = headCars, Result = true, Message = "OK" });
            }
            catch (Exception e)
            {
                return Json(new { Result = false, Message = e.Message });
            }
        }
    }
}
