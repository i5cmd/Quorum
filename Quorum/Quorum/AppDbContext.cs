using Microsoft.EntityFrameworkCore;
using Quorum;

namespace Quorum
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Projekt> projekty { get; set; }
    }
}
