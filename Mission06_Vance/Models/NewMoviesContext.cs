using Microsoft.EntityFrameworkCore;

namespace Mission06_Vance.Models
{
    public class NewMoviesContext : DbContext
    {
        public NewMoviesContext(DbContextOptions<NewMoviesContext> options) : base (options) 
        { 
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
