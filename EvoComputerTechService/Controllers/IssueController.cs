using Microsoft.AspNetCore.Mvc;

namespace EvoComputerTechService.Controllers
{
    public class IssueController : Controller
    {
        [HttpGet]
        public IActionResult GetIssues()
        {
            return View();
        }
    }
}
