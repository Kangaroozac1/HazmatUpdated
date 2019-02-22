using Microsoft.EntityFrameworkCore;

namespace Hazmat
{
    internal class AppDbContext : DbContext
    {

        public DbSet<Object> ObjIDs { get; set; }

        public DbSet<Scanner> ScannerIDs { get; set; }

        public DbSet<Login> Login { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}