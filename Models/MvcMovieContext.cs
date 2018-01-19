using Microsoft.EntityFrameworkCore;

namespace Todo.Web.Models
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Todo.Web.Models.Movie> Movie { get; set; }
    }
}
