using Microsoft.AspNetCore.Mvc;
using KnockOutSelectors.Repository;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using KnockOutSelectors.Models;

namespace KnockOutSelectors.Controllers
{
    public class HomeController : Controller
    {
        private readonly WorldRepository worldRepository;

        public HomeController(IConfiguration configuration)
        {
            worldRepository = new WorldRepository(configuration);
        }

        public ActionResult Index()
        {
            ViewBag.Message = "ASP.NET MVC with KnockOut";
            //if (Model == null)
            //    Model = new HomeModel();

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
