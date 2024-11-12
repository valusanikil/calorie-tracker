using Microsoft.EntityFrameworkCore;
using Calorie.Models;

namespace Calorie.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<CalorieEntry> CalorieEntries { get; set; }
    }
}
