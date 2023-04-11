using Microsoft.EntityFrameworkCore;
using Villa_Api.Models;

namespace Villa_Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        public DbSet<Villa> Villas { get; set; }
    }
}
