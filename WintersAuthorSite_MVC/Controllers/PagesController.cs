using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WintersAuthorSite_MVC.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("List", "Publications");
        }

        public IActionResult Welcome()
        {
            return RedirectToAction("List", "Publications");
        }

        public IActionResult Home()
        {
            return RedirectToAction("List", "Publications");
        }

        public IActionResult PreviousPublications()
        {
            return RedirectToAction("List", "Publications");
        }

        public IActionResult Biography()
        {
            return RedirectToAction("About", "Author");
        }

        public IActionResult Contact()
        {
            return RedirectToAction("Contact", "Author");
        }

        public IActionResult Credits()
        {
            return RedirectToAction("Contact", "Author");
        }

        public IActionResult GravediggerCollection()
        {
            return RedirectToAction("GraveDigger", "Publications");
        }

        public IActionResult ReadGravedigger()
        {
            return RedirectToAction("Read", "Publications");
        }
    }
}