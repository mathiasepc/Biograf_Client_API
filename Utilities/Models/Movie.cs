
namespace Utilities.Models;

public class Movie : BaseModel
{
    public int? Length { get; set; }

    public ICollection<Actor>? Actors { get; set; } = new List<Actor>();
    public ICollection<Hall>? Halls { get; set; } = new List<Hall>();
    public ICollection<Theme>? Themes { get; set; } = new List<Theme>();

    public override void MapObject(dynamic m)
    {
        Length = m.length;
        Actors = m.actors;
        Halls = m.halls;
        Themes = m.themes;
    }

}

