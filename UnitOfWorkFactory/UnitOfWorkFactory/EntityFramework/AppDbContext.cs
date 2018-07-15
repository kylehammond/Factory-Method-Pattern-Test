using System.Data.Entity;
using UnitOfWorkFactory.Entities;

namespace UnitOfWorkFactory.EntityFramework
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public DbSet<Banana> Bananas { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}