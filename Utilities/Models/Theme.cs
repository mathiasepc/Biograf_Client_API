
namespace Utilities.Models;

public class Theme : BaseModel
{
    public ICollection<Movie>? Movies { get; set; } = new List<Movie>();

    public override void MapObject(dynamic m)
    {
        Movies = m.movies;
    }
}

