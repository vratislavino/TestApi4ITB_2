using Microsoft.EntityFrameworkCore;
using TestApi4ITB_2.Models;

namespace TestApi4ITB_2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<User> Users { get; set; }
    }
}
