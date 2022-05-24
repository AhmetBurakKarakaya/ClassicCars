using ClassicCars.Data.Contexts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassicCars.Controllers
{
    public class ImageGalleryController : Controller
    {

        private readonly ClassicCarsContext _context;

        public ImageGalleryController(ClassicCarsContext context)
        {
            _context = context;
        }

        public IActionResult ImageGallery()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetImageGallery()
        {
            try
            {
                var imageGallery = _context.ImageGalleries.Where(p => p.IsActive == true).OrderBy(v => v.Id).Take(6);
                return Json(new { data = imageGallery, Result = true, Message = "OK" });
            }
            catch (Exception e)
            {
                return Json(new { Result = false, Message = e.Message });
            }
        }

        


    }
}
