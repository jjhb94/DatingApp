using API.Entities; // injects AppUser
using Microsoft.EntityFrameworkCore; // this injetcs DbContext

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
    }
}