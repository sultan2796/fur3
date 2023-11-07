
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FurniApp2.Models
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            l
        }
        DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        DbSet<Team> Teams { get; set; }

    }
}
