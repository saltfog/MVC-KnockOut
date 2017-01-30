using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KnockOutSelectors.Models;
using KnockOutSelectors.Repository;
using Microsoft.Extensions.Configuration;

namespace KnockOutSelectors.Controllers.Api
{
    [Route("api/[controller]")]
    public class WorldController : Controller
    {
        private readonly WorldRepository worldRepository;

        public WorldController(IConfiguration configuration)
        {
            worldRepository = new WorldRepository(configuration);
        }

        //GET: api/values
       [HttpGet("api/World")]
        public JsonResult GetWorld()
        {
            List<World> list = new List<Models.World>();
            list = worldRepository.GetWorld();
            return Json(list);
        }

        //GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
