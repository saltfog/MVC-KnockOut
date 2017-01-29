using Microsoft.AspNetCore.Mvc;
using KnockOutSelectors.Models;
using KnockOutSelectors.Repository;
using Microsoft.Extensions.Configuration;

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


        public ActionResult World()
        {
            var list = worldRepository.GetWorld();
            return Json(list);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
