using dotnetapp.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetapp.Data
{
    public class ApplicationDBContext: DbContext

    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :base (options)
        {
                
        }

        public DbSet<Category> categories { get; set; } //its create categories table in DB and app connect through this

    }
}
