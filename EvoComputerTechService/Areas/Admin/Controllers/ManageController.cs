using Microsoft.AspNetCore.Mvc;

namespace EvoComputerTechService.Areas.Admin.Controllers
{
    public class ManageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
