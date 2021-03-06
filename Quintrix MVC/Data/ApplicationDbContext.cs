using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Quintrix_MVC.Models;

namespace Quintrix_MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext <PushinP>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<PlayerModel> Player { get; set; }
    }
}