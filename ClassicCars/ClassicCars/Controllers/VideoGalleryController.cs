using ClassicCars.Data.Contexts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassicCars.Controllers
{
    public class VideoGalleryController : Controller
    {
        private readonly ClassicCarsContext _context;

        public VideoGalleryController(ClassicCarsContext context)
        {
            _context = context;
        }

        public IActionResult VideoGallery()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetVideoGallery()
        {
            try
            {
                var videoGallery = _context.VideoGalleries.Where(p => p.IsActive == true).OrderBy(v => v.Id).Take(3);
                return Json(new { data = videoGallery, Result = true, Message = "OK" });
            }
            catch (Exception e)
            {
                return Json(new { Result = false, Message = e.Message });
            }
        }

        [HttpPost]
        public JsonResult GetVideoGallery2()
        {
            try
            {
                var videoGallery = _context.VideoGalleries.Where(p => p.IsActive == true).OrderBy(v => v.Id).Skip(3).Take(3);
                return Json(new { data = videoGallery, Result = true, Message = "OK" });
            }
            catch (Exception e)
            {
                return Json(new { Result = false, Message = e.Message });
            }
        }


    }
}
