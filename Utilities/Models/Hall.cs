
namespace Utilities.Models;

public class Hall : BaseModel
{
    [Required]
    public int? Row { get; set; }
    [Required]
    public int? Column { get; set; }

    public ICollection<Movie>? Movies { get; set; } = new List<Movie>();
    public ICollection<Cinema>? Cinemas { get; set; } = new List<Cinema>();
}

