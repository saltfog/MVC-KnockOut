using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KnockOutSelectors.Models;
using KnockOutSelectors.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Routing;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace KnockOutSelectors.Controllers
{
    public class WorldController : Controller
    {
        private readonly WorldRepository worldRepository;

        public WorldController(IConfiguration configuration)
        {
            worldRepository = new WorldRepository(configuration);
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(worldRepository.GetWorld());
        }

        [HttpGet("world/getworld")]
        public IActionResult GetWorld()
        {
            var list = worldRepository.GetWorld().ToList();
            return Json(list);
        }
    }
}
