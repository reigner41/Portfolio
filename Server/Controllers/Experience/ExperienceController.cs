using Microsoft.AspNetCore.Mvc;
using PortfolioWithServer.Shared.Models;
using System.Collections.Generic;

namespace PortfolioWithServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExperienceController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Experience>> GetExperiences()
        {
            var experiences = ExperienceSeeder.GetExperiences();
            Console.WriteLine(experiences);
            return Ok(experiences);
        }
    }
}