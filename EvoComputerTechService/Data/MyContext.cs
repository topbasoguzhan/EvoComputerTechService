using EvoComputerTechService.Models.Entities;
using EvoComputerTechService.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EvoComputerTechService.Data
{
    public class MyContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        public DbSet<Issue> Issues { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            //builder.Entity<Issue>()
            //    .HasOne(x => x.User)
            //    .WithMany(x => x.Issues)
            //    .HasForeignKey(x => x.UserId);

            //builder.Entity<Issue>()
            //    .HasOne(x => x.Technician)
            //   .WithMany(x => x.Technician)
            //   .HasForeignKey(x => x.TechnicianId);
        }
    }
}
