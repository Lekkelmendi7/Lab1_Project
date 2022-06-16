
namespace Leke_Kelmendi_Edukimi_CRUD_API.Data
{
    public class DataContext : DbContext
    {
        
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Edukimi> Edukimi { get; set; }
    }
}

