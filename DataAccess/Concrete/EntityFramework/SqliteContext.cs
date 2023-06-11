using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class SqliteContext : DbContext
    {
        // public SqliteContext(DbContextOptions options) : base(options)
        // {
        // }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite(@"Data source=../DataAccess/server.db");
        }
        public DbSet<Product> Products { get; set; }
    }
}