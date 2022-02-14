using EvoComputerTechService.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EvoComputerTechService.Data
{
    public class MyContext : IdentityDbContext<ApplicationUser,ApplicationRole,string>
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
    }
}
