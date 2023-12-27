
namespace Repositories.Database;

public class DatabaseContext : DbContext
{

    public DatabaseContext(DbContextOptions<DatabaseContext> option) : base(option) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Hall> Halls { get; set; }
    public DbSet<Cinema> Cinemas { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Actor> Actors { get; set; }
}
