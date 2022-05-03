using Microsoft.EntityFrameworkCore;

namespace lab1.Models
{
    public class labDbContext : DbContext
    {
        public labDbContext(DbContextOptions<labDbContext> options) : base(options)
        {

        }

        public DbSet<Qyteti> Qytetet { get; set; }
    }
}
