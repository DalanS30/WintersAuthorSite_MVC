using Microsoft.AspNetCore.Mvc;

namespace WintersAuthorSite_MVC.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View("About");
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}