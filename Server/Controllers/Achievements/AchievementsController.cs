using Microsoft.AspNetCore.Mvc;
using PortfolioWithServer.Shared.Models;
using System.Collections.Generic;

namespace PortfolioWithServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AchievementsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Achievement>> GetAchievements()
        {
            var achievements = AchievementSeeder.GetAchievements();
            return Ok(achievements);
        }
    }
}
