using Microsoft.EntityFrameworkCore;

namespace Leke_Kelmendi_Kontrata_CRUD.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Kontrata> Kontrata { get; set; }
    }
}
