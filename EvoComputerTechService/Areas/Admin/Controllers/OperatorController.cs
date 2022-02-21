using Microsoft.AspNetCore.Mvc;

namespace EvoComputerTechService.Areas.Admin.Controllers
{
    public class OperatorController : OperatorBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
