using EvoComputerTechService.Data;
using EvoComputerTechService.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace EvoComputerTechService.Areas.Admin.Controllers
{
    public class OperatorController : OperatorBaseController
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly MyContext _dbContext;
        

        public OperatorController(MyContext dbContext, UserManager<ApplicationUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AllIssues()
        {
            var allIssues = _dbContext.Issues.ToList();
            return View(allIssues);
        }

        [HttpGet]
        public IActionResult IssueDetail(Guid id)
        {
            var issue = _dbContext.Issues.Find(id);
            if (issue == null)
            {

            }
            return View(issue);
        }
    }
}
