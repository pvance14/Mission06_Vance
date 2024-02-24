using Microsoft.EntityFrameworkCore;

namespace Mission06_Vance.Models
{
    public class NewMoviesContext : DbContext //liaison from the app to the database
    {
        public NewMoviesContext(DbContextOptions<NewMoviesContext> options) : base (options) // constructor
        { 
        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
