using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using travelAgency.Model;

namespace travelAgency.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<tour> Tours { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<days> Days { get; set; }
    }
}