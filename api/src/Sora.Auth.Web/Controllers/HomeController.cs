using Microsoft.AspNetCore.Mvc;

namespace Sora.Auth.Web.Controllers
{
    public class HomeController : AuthControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}