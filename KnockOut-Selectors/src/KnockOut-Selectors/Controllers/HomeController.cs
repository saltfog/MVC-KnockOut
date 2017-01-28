using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KnockOutSelectors.Models;

namespace KnockOutSelectors.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "ASP.NET MVC with KnockOut";

            if (Model == null)
                Model = new World();

            return View();
        }


        public ActionResult GetWorlds()
        {
            return Json(Model);
        }

        public static World Model { get; set; }

        public ActionResult About()
        {
            return View();
        }
    }
}
