
namespace Utilities.Models;

public class Actor : BaseModel
{
    public int? Age { get; set; }

    public ICollection<Movie>? Movies { get; set; } = new List<Movie>();

    public override void MapObject(dynamic m)
    {
        Age = m.age;
        Movies = m.movies;
    }
}
