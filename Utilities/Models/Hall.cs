
namespace Utilities.Models;

public class Hall : BaseModel
{
    public int? Row { get; set; }
    public int? Column { get; set; }

    public ICollection<Movie>? Movies { get; set; } = new List<Movie>();
    public ICollection<Cinema>? Cinemas { get; set; } = new List<Cinema>();

    public override void MapObject(dynamic m)
    {
        Row = m.row;
        Column = m.column;
        Movies = m.movies;
        Cinemas = m.cinemas;
    }
}

