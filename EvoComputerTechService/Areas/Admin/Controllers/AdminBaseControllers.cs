using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EvoComputerTechService.Areas.Admin.Controllers
{
    public class AdminBaseControllers
    {
        [Authorize(Roles = "Admin")]
        public class AdminBaseController : Controller
        {

        }
    }
}
