
namespace Utilities.Models;

public class Theme : BaseModel
{
    public ICollection<Movie>? Movies { get; set; } = new List<Movie>();
}

