using Microsoft.EntityFrameworkCore;

namespace ProClimberAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<ProClimber> ProClimbers => Set<ProClimber>();
    }
}
