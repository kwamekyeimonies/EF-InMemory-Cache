using Microsoft.EntityFrameworkCore;
using InMemory_Cache.Models;

namespace InMemory_Cache.Database
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }

        public DbSet<Users> Users { get; set; }
    }
}