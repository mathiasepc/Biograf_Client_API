

namespace Utilities.Models;

public class Theme : BaseModel
{
    [JsonIgnore]
    public ICollection<Movie>? Movies { get; set; } = new List<Movie>();
}

