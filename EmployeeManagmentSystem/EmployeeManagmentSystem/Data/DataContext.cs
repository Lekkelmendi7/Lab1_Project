using Microsoft.EntityFrameworkCore;

namespace EmployeeManagmentSystem.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Departamenti> Departmentet { get; set; }
    }
}
