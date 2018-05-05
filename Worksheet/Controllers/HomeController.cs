using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Worksheet.Service;
using Worksheet.ViewModels;

namespace Worksheet.Controllers
{
    public class HomeController : Controller
    {
        WorksheetService _service;

        public HomeController()
        {
            _service = new WorksheetService();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(FullViewModel model)
        {
            if (!model.Agreement)            
                ModelState.AddModelError("Agreement", "Для участия вы должны согласиться с условиями проекта");            

            if (ModelState.IsValid)
            {
                _service.SaveData(model);

                return RedirectToAction("Index");                
            }

            return View(model);
        }
    }
}