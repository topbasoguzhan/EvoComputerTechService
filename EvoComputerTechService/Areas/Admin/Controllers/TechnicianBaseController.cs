using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EvoComputerTechService.Areas.Admin.Controllers
{
    [Authorize(Roles = "Technician")]
    public class TechnicianBaseController : Controller
    {

    }
}
