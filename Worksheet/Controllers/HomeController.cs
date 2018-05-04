using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Worksheet.ViewModels;

namespace Worksheet.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FullViewModel model)
        {
            return View();
        }
    }
}