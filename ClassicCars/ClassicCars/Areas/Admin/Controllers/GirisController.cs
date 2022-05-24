using ClassicCars.Data.Contexts;
using ClassicCars.Data.Entities;
using Microsoft.AspNetCore.Http;

using System;
using System.Linq;
using ClassicCars.Areas.Admin.Filters;
using Microsoft.AspNetCore.Mvc;

namespace ClassicCars.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GirisController : Controller
    {
        private readonly ClassicCarsContext db;
        public GirisController(ClassicCarsContext context)
        {
            db = context;
        }
        public IActionResult Giris()
        {
            return View();
        }

        [HttpPost("api/giris")]
        //[Route("api/giris")]
        public JsonResult girissorgula([FromBody] Users data)
        {
            try
            {
                //From body null
                string email = "ahmet.karakaya99@erzurum.edu.tr";
                string parola = "123456";

                if (string.IsNullOrEmpty(parola) && string.IsNullOrEmpty(email))
                {
                    
                    return Json(new { result = false, message = "kullanıcı adınızı ve şifrenizi girmediniz!" });
                }
                else if (string.IsNullOrEmpty(email))
                {
                    return Json(new { result = false, message = "kullanıcı adınızı girmediniz!" });
                }
                else if (string.IsNullOrEmpty(parola))
                {
                    return Json(new { result = false, message = "şifrenizi girmediniz!" });
                }
                else
                {

                    var kullanici = db.Users.FirstOrDefault(x => x.Email == email && x.Parola == parola && x.Role == 1);

                    if (kullanici == null) return Json(new { result = false, message = "kullanıcı adınızı ya da şifreyi hatalı girdiniz!" });


                    //güvenlik açısından bilgileri şifreleyerek saklamamız daha doğru bir yöntemdir.
                    //asp.net membership yapısı, bu güvenliği sunmaktadır.

                    HttpContext.Session.SetInt32("Kullanici_ID", kullanici.Id); // Yeni bir session oluşturma.
                    HttpContext.Session.SetString("Ad", kullanici.Name);
                    HttpContext.Session.SetString("Soyad", kullanici.LastName);
                    HttpContext.Session.SetString("Resim", kullanici.Tumbnail);
                    HttpContext.Session.SetInt32("Rol", kullanici.Role);



                    HttpContext.Session.SetInt32("KullaniciRol", kullanici.Role);
                    HttpContext.Session.SetInt32("YoneticiRol", kullanici.Role);




                    //burada eğer, kullanıcı bilgileri, sistemde eşleşirse, geriye girişin başarılı
                    //olduğuna dair bir mesaj ve 3 saniye sonra, ana sayfaya yönlendirecek bir
                    //javascript kodu ekliyoruz.        
                    return Json(new { result = true, message = "başarıyla giriş yaptınız. yönlendiriliyorsunuz...", url = "/Admin/Giris/Anasayfa" });
                    // return "başarıyla giriş yaptınız. yönlendiriliyorsunuz...<script type='text/javascript'>settimeout(function(){window.location='/admin/giris/anasayfa'},2000);</script>";
                }

            }
            catch (Exception ex)
            {

                return Json(new { result = false, message = ex.Message });
            }

        }
        public IActionResult OturumuKapat()
        {
            HttpContext.Session.Clear(); // Tüm sessionları temizle
            return View("Giris");
        }

        //[ServiceFilter(typeof(AdminUserSecurityAttribute))]
        public IActionResult Anasayfa()
        {
            return View();
        }
    }
}
