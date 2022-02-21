using Microsoft.AspNetCore.Mvc;

namespace EvoComputerTechService.Areas.Admin.Controllers
{
    public class AdminController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Users()
        {
            return View();
        }
    }
}
