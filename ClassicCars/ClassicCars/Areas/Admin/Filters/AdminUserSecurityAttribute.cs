using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ClassicCars.Areas.Admin.Filters
{
    public class AdminUserSecurityAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filtercontext)
        {
            if (filtercontext.HttpContext.Session.GetString("YoneticiRol") == null)
            {
                filtercontext.HttpContext.Response.Redirect("Hata");
            }

            base.OnActionExecuting(filtercontext);
        }
    }
}
