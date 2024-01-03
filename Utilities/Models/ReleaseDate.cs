

namespace Utilities.Models;

public class ReleaseDate : BaseModel
{
    [Required]
    public DateTime Date { get; set; }

    public ICollection<Movie>? Movies { get; set; } = new List<Movie>();
}
