using Microsoft.AspNetCore.Mvc;

namespace EvoComputerTechService.Areas.Admin.Controllers
{
    public class TechnicianController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
