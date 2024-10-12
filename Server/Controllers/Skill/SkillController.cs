using Microsoft.AspNetCore.Mvc;
using PortfolioWithServer.Shared.Models;

namespace PortfolioWithServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SkillController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Skill>> GetSkills()
        {
            var skills = SkillSeeder.GetSkills();
            Console.WriteLine(skills);
            return Ok(skills);
        }
    }
}