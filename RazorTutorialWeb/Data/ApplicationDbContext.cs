using Microsoft.EntityFrameworkCore;
using RazorTutorialWeb.Model;

namespace RazorTutorialWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Category { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
