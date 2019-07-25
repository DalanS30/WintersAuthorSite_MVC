using Microsoft.AspNetCore.Mvc;

namespace WintersAuthorSite_MVC.Controllers.Publications
{
    public class PublicationsController : Controller
    {
        public IActionResult Index()
        {
            return View("List", Utils.GetPublications());
        }

        public IActionResult List()
        {
            return View("List", Utils.GetPublications());
        }

        public IActionResult Gravedigger()
        {
            return View();
        }

        public FileResult Download(string fileName)
        {
            if (System.IO.File.Exists($"wwwroot/data/{fileName}"))
            {
                return File(System.IO.File.ReadAllBytes($"wwwroot/data/{fileName}"), "application/x-msdownload", fileName);
            }
            return null;
        }

        public IActionResult Read()
        {
            return View();
        }

        public IActionResult Nabit()
        {
            return View();
        }

        public IActionResult Daisy()
        {
            return View();
        }
    }
}