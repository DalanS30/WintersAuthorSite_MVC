using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}